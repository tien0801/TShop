﻿
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TShop.Model.Models;
using TShop.Web.Models;

namespace TShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Post, PostViewModel>();
                    cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                    cfg.CreateMap<Tag, TagViewModel>();
                }
            );
        }
    }
}