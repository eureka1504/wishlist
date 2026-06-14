using Microsoft.AspNetCore.Mvc;
using WishList.Api.Models.WishLists;
using WishList.Application.Interfaces;

namespace WishList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishListController : ControllerBase
    {
        private readonly IGetWishListByIdService _getWishListByIdService;
        private readonly IGetUserWishListsService _getUserWishListService;
        private readonly ICreateWishListService _createWishListService;

        public WishListController(
            IGetWishListByIdService getWishListByIdService,
            IGetUserWishListsService getUserWishListsService,
            ICreateWishListService createWishListService
        )
        {
            _getWishListByIdService = getWishListByIdService;
            _getUserWishListService = getUserWishListsService;
            _createWishListService = createWishListService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var wishList = await _getWishListByIdService.GetByIdAsync(id);

            return Ok(wishList);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId(Guid userId)
        {
            var wishLists = await _getUserWishListService.GetAsync(userId);

            return Ok(wishLists);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateWishListRequest request)
        {
            var wishListId = await _createWishListService.CreateAsync(request.UserId, request.Name);

            return Ok(wishListId);
        }
    }
}
