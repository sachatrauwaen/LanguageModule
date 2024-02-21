using Satrabel.LanguageModule.Samples;
using Xunit;

namespace Satrabel.LanguageModule.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<LanguageModuleMongoDbTestModule>
{

}
