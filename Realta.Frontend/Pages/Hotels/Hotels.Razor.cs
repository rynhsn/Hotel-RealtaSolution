using Microsoft.AspNetCore.Components;
using Realta.Contract.Models.v1.Hotels;
using Realta.Frontend.HttpRepository;

namespace Realta.Frontend.Pages.Hotels
{
    public partial class Hotels
    {
        [Inject]
        public IHotelsHttpRepository? HotelRepo { get; set; }
        public List<HotelsDto> HotelList { get; set; } = new List<HotelsDto>();
        protected override async Task OnInitializedAsync()
        {
            HotelList = await HotelRepo.GetHotels(); 
        }
    }
}
