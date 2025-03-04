﻿using DeveLanCacheUI_Backend.Services;

namespace DeveLanCacheUI_Backend.Tests.ProtoTest
{
    [TestClass]
    public class SuperProtoTest
    {
        [TestMethod]
        public void GoTest()
        {
            var path = Path.Combine("ProtoTest", "10336669592858206477");
            var allBytes = File.ReadAllBytes(path);

            var dbSteamManifest = SteamManifestService.ManifestBytesToJsonValue(allBytes);

            Assert.IsNotNull(dbSteamManifest);
        }
    }
}
