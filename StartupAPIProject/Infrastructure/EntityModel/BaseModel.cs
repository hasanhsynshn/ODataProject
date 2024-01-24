namespace StartupAPIProject.Infrastructure.EntityModel
{
    /// <summary>
    /// Base class for all models and generic type is Id
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseModel<T>
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
