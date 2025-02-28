namespace Yummy.WebAPI.DTOs.FeatureDtos
{
    public class CreateFeatureDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string videoUrl { get; set; }
        public string imageUrl { get; set; }
    }
}
