using symphonyz.Core.Metadata;

var metadata = new AudioMetadata();
foreach (var (key, value) in metadata.Properties)
{
    Console.WriteLine($"{key} : {value}");
}