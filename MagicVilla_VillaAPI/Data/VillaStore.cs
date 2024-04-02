﻿using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO {Id=1, Name="First", Sqft=100, Occupancy=4},
                new VillaDTO {Id=2, Name="Second", Sqft=200, Occupancy=7}
            };
    }
}