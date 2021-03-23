using System.ComponentModel;
using System.Threading.Tasks;

namespace MinRepo.Grains.Interfaces
{
    public interface IHello : Orleans.IGrainWithIntegerKey
    {
        // This options will work: 
        // Task<string> SayHello(string greeting);
        // Task<RecordDto> SayHello(string greeting);
        // Task<RecordDtoClass> SayHello(string greeting);
        // Task<RecordDtoClass[]> SayHello(string greeting);


        // This option will lead to error:
        // Exception while trying to run client: Named type "MinRepo.Grains.Interfaces.RecordDto" is invalid: Type string "MinRepo.Grains.Interfaces.RecordDto" cannot be resolved.
        Task<RecordDto[]> SayHello(string greeting);
    }

    public record RecordDto(string Value);

    public class RecordDtoClass
    {
        public string Value { get; }

        public RecordDtoClass(string value)
        {
            Value = value;
        }
    }
}

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class IsExternalInit { }
}
