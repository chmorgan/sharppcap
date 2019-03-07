[![NuGet Version](https://img.shields.io/nuget/v/SharpPcap.svg?style=flat-square&label=NuGet&logo=nuget)](https://www.nuget.org/packages/SharpPcap/)
[![AppVeyor CI builds](https://img.shields.io/appveyor/ci/chmorgan/sharppcap/master.svg?style=flat-square&label=AppVeyor&logo=appveyor)](https://ci.appveyor.com/project/chmorgan/sharppcap/branch/master)

# sharppcap
Fully managed, cross platform (Windows, Mac, Linux) .NET library for capturing packets from live and file based devices

The official SharpPcap repository.

# Features
Note that packet dissection and creation was split from SharpPcap some years ago into a separate project, [Packet.Net](https://github.com/chmorgan/packetnet). See the Packet.Net page for a full list of supported packet formats.

* On Linux, support for [libpcap](http://www.tcpdump.org/manpages/pcap.3pcap.html)

* On Windows, support for:
  * Npcap (formerly WinPcap) extensions, see [Npcap API guide](https://nmap.org/npcap/guide/npcap-devguide.html#npcap-api)
  * AirPcap see (https://support.riverbed.com/content/support/software/steelcentral-npm/airpcap.html)

# Examples
See the [Examples](https://github.com/chmorgan/sharppcap/tree/master/Examples) folder for a range of examples using SharpPcap
