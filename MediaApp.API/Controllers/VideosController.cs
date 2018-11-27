using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using MediaApp.API.Data;
using MediaApp.API.Dtos;
using MediaApp.API.Helpers;
using MediaApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace MediaApp.API.Controllers
{
    [Authorize]
    [Route("api/users/{userId}/videos")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly IMediaRepository _repo;
        private readonly IMapper _mapper;
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;
        private Cloudinary _cloudinary;

        public VideosController(IMediaRepository repository, IMapper mapper,  IOptions<CloudinarySettings> cloudinaryConfig)
        {
            _cloudinaryConfig = cloudinaryConfig;
            _mapper = mapper;
            _repo = repository;

            Account acc = new Account(
                _cloudinaryConfig.Value.CloudName,
                _cloudinaryConfig.Value.ApiKey,
                _cloudinaryConfig.Value.ApiSecret
            );

            _cloudinary = new Cloudinary(acc);

        }

        [HttpGet("{id}", Name = "GetVideo")]
        public async Task<IActionResult> GetVideo(int id){
            var videoFromRepo = await _repo.GetVideo(id);
            var video = _mapper.Map<VideoForReturnDto>(videoFromRepo);
            return Ok(video);
        }

        [HttpPost]
        public async Task<IActionResult> AddVideoForUser(int userId, VideoForCreationDto videoForCreationDto){
            //let's authenticate the user before allowing them to upload
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();
            var userFromRepo = await _repo.GetUser(userId);

            //begin upload
            var file = videoForCreationDto.File;
            if (file.Length > 0){
                using (var stream = file.OpenReadStream()){
                    var uploadParams = new VideoUploadParams() {
                        File = new FileDescription(file.Name, stream),
                        // Transformation = new Transformation().Width(500).Height(500).Crop("fill").Gravity("face")
                        // This will transform the photo to the above specifications - probably don't want this for now
                    };

                    var uploadResult = _cloudinary.Upload(uploadParams);
                    videoForCreationDto.Url = uploadResult.Uri.ToString();
                    videoForCreationDto.PublicId = uploadResult.PublicId;
                }
            }

            var video = _mapper.Map<Models.Video>(videoForCreationDto);
            if (!userFromRepo.Videos.Any(u => u.IsFavorite))
                video.IsFavorite = true;

            userFromRepo.Videos.Add(video);

            if (await _repo.SaveAll()) {
                return Ok();
            }
            return BadRequest("Could not add the video");
        }
}
}