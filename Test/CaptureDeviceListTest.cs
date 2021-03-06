﻿using System;
using SharpPcap;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class CaptureDeviceListTest
    {
        /// <summary>
        /// Test that we can create a new device list
        /// </summary>
        [Test]
        public void CaptureDeviceListNew()
        {
            var deviceList = CaptureDeviceList.New();
            Assert.IsNotNull(deviceList);
            Assert.IsNotEmpty(deviceList);
        }
    }
}
