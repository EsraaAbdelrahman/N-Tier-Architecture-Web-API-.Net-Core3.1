using AutoMapper;
using MyMusic.API.Resources;
using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusic.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Music, MusicResource>();
            CreateMap<Artist, ArtistResource>();
            CreateMap<Music, SaveResourceMusic>();
            CreateMap<Artist, SaveArtistResource>();
            CreateMap<User, UserResource>();
            CreateMap<Composer, ComposerResource>()
                   .ForMember(c => c.Id, opt => opt.MapFrom(c => c.Id.ToString()));

            //CreateMap<Composer, SaveComposerResource>();


            //Resource to Domain
            CreateMap<MusicResource, Music>();
            CreateMap<ArtistResource, Artist>();
            CreateMap<SaveResourceMusic, Music>();
            CreateMap<SaveArtistResource, Artist>();
            CreateMap<ComposerResource, Composer>()
                    .ForMember(m => m.Id, opt => opt.Ignore());
            CreateMap<SaveComposerResource, Composer>();
            CreateMap<UserResource, User>();

        }
    }
}
