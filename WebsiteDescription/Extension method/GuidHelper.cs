using System;

namespace WebsiteDescription
{
    public static class GuidHelper
    {
        public static void SetID(this TrainingBaseEntity uniqueIdentificator)
        {
            uniqueIdentificator.Id = Guid.NewGuid();
        }
    }
}
