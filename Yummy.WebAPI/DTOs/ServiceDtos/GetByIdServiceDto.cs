﻿namespace Yummy.WebAPI.DTOs.ServiceDtos
{
    public class GetByIdServiceDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string iconUrl { get; set; }
    }
}
