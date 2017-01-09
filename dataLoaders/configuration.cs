using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Wotan;

namespace dataLoader
{
    public class winLoggerContract : loggerContract
    {
        [DataMember(IsRequired = true, Name = "log", Order = 1)]
        public string log { get; set; }

        [DataMember(IsRequired = true, Name = "source", Order = 2)]
        public string source { get; set; }

        public override logger create() { return new winLogger(log, source, threshold); }
    }
    public class consoleLoggerContract : loggerContract
    {
        public override logger create() { return new consoleLogger(threshold); }
    }

    [DataContract(Name = "logger")]
    [KnownType(typeof(winLoggerContract))]
    [KnownType(typeof(consoleLoggerContract))]
    public abstract class loggerContract
    {
        [DataMember(IsRequired = true, Name = "threshold", Order = 0)]
        public verbosity threshold { get; set; }

        public abstract logger create();
    }

    public class database
    {

    }

    // TODO: use code contracts
    [DataContract(Name = "configuration")]
    public class configuration : service.IConfiguration
    {
        [DataMember(IsRequired = true, Name = "logger", Order = 0)]
        public loggerContract logger { get; set; }

        [DataMember(IsRequired = true, Name = "database", Order = 1)]
        public database database { get; set; }
    }
}
