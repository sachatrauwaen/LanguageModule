using Satrabel.LanguageModule.MongoDB;
using Satrabel.LanguageModule.Samples;
using Xunit;

namespace Satrabel.LanguageModule.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<LanguageModuleMongoDbTestModule>
{

}
