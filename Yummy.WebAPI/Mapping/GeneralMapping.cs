using AutoMapper;
using Yummy.WebAPI.DTOs.ContactDtos;
using Yummy.WebAPI.DTOs.FeatureDtos;
using Yummy.WebAPI.DTOs.MessageDtos;
using Yummy.WebAPI.DTOs.ProductDtos;
using Yummy.WebAPI.DTOs.ReservationDtos;
using Yummy.WebAPI.DTOs.ServiceDtos;
using Yummy.WebAPI.DTOs.TestimonialDtos;
using Yummy.WebAPI.Entities;

namespace Yummy.WebAPI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            // Feature DTOs
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            // Contact DTOs
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, GetByIdContactDto>().ReverseMap();

            // Message DTOs
            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessage>().ReverseMap();

            // Product DTOs
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            // Reservation DTOs
            CreateMap<Reservation, ResultReservationDto>().ReverseMap();
            CreateMap<Reservation, CreateReservationDto>().ReverseMap();
            CreateMap<Reservation, UpdateReservationDto>().ReverseMap();
            CreateMap<Reservation, GetByIdReservationDto>().ReverseMap();

            // Service DTOs
            CreateMap<Service, ResultServiceDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, GetByIdServiceDto>().ReverseMap();

            // Testimonial DTOs
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetByIdTestimonialDto>().ReverseMap();
            /*ReverseMap() metodunu kullanmamızın sebebi, AutoMapper'ın hem DTO'dan Entity'ye hem de Entity'den
             DTO'ya dönüşümü otomatik olarak yapmasını sağlamaktır.
             ReverseMap() 
            Kullanmanın Avantajları
                Kod Tekrarını Azaltır

                Aynı eşlemeyi iki kez tanımlamak yerine tek satırda hallederiz.
                İki Yönlü Dönüşüm Sağlar

            Feature entity'sinden ResultFeatureDto'ya çevirebiliriz.
            ResultFeatureDto'dan Feature entity'sine çevirebiliriz.
            Bakımı Kolaylaştırır

            Tek bir değişiklik yaparak iki yönlü dönüşümü de etkileyebiliriz.
            Eğer DTO veya entity'de bir alan ekler veya değiştirirsek, bunu sadece tek bir yerde güncellememiz yeterli olur.
             */
        }
    }
}
