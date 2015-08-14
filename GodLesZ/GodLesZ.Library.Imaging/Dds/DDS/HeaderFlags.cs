﻿using System;

namespace Gibbed.Squish.DDS {
	[Flags]
	public enum HeaderFlags : uint {
		Texture = 0x00001007,	// DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT 
		Mipmap = 0x00020000,	// DDSD_MIPMAPCOUNT
		Volume = 0x00800000,	// DDSD_DEPTH
		Pitch = 0x00000008,	// DDSD_PITCH
		LinerSize = 0x00080000,	// DDSD_LINEARSIZE
	}
}