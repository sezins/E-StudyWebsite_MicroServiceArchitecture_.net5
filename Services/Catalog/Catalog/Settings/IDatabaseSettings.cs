namespace Catalog.Settings
{
    public interface IDatabaseSettings
    {
        public string CourseCollectionName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string CoonectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
