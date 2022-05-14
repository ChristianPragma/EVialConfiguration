namespace EVialConfig.Domain.Dtos
{
    public class InsertCacheDto<T> where T : class
    {
        public string Key { get; set; }

        public T Data { get; set; }  
    }
}
