namespace Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CourseCollectionName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string CoonectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
