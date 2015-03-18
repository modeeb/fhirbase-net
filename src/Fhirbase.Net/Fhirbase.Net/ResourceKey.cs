namespace Fhirbase.Net
{
    public class ResourceKey
    {
        /// <summary>
        /// Type name of Resource
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Resource id
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Version id
        /// </summary>
        public string VersionId { get; set; }
    }
}