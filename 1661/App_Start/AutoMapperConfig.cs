using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using AutoMapper;
using _1661.Models;
using _1661.Models.Data;

namespace _1661.App_Start
{
    public class AutoMapperConfig
    {
        public static void AutoMapperReg()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<MyStorege,SubMyStorege>().ForMember(x=>x.IDst,y=>y.MapFrom(a=>a.ST.IDST)).ForMember(x=>x.IDsf,y=>y.MapFrom(a=>a.SF.IDSF)).ForMember(x=>x.NameSF,y=>y.MapFrom(a=>a.SF.StorageFeatures)).ForMember(x=>x.NameST,y=>y.MapFrom(a=>a.ST.StorageType));
                cfg.CreateMap<SubMyStorege,MyStorege>();

               

                cfg.CreateMap<SF,SubSF>();
                cfg.CreateMap<SubSF,SF>();

                cfg.CreateMap<ST,SubST>();
                cfg.CreateMap<SubST,ST>();

            });
        }
    }
}