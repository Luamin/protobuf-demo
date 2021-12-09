using System.Net.Http.Headers;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ProtoTestApi
{
    public static class ProtobufFormatterMvcBuilderExtensions
    {
        //  public static IMvcBuilder AddProtobufFormatters(this IMvcBuilder builder){
        //      var protobufFormatterOptions = new ProtobufFormatterOptions();
        //      builder.AddFormatterMappings((Action<FormatterMappings>)(m => m.SetMediaTypeMappingForFormat("application/x-protobuf", new MediaTypeHeaderValue("application/x-protobuf"))));
        //      builder.AddMvcOptions(options => options.InputFormatters.Add(new ProtoBufFormatter()));
        //  }
    }

    public class ProtobufFormatterOptions{
        public HashSet<string> SupportedContentType {get;set;} = new HashSet<string>{
            "application/x-protobuf"
        };

        public HashSet<string> SupportedExtensions {get;set;} = new HashSet<string>{
            "application/x-protobuf"
        };
    }
}