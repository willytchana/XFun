
namespace XFun.Api.Common
{
    public class JsonObject<T>
    {
        public T Data { get; set; }
        public bool Status { get; set; }

        public JsonObject()
        {
                
        }

        public JsonObject(T data)
        {
            Data = data;
            Status = true;
        }

        public JsonObject(T data, bool status)
        {
            Data = data;
            Status = status;
        }
    }
}