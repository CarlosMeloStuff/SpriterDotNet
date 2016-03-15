﻿// Copyright (c) 2015 The original author or authors
//
// This software may be modified and distributed under the terms
// of the zlib license.  See the LICENSE file for details.

namespace SpriterDotNet.Providers
{
    public class DefaultAnimationDataProvider : IAnimationDataProvider
    {
        private readonly FrameData data = new FrameData();

        public virtual FrameData GetFrameData(float time, float deltaTime, float factor, SpriterAnimation first, SpriterAnimation second = null)
        {
            data.Clear();

            if (second == null)
            {
                SpriterProcessor.UpdateFrameData(data, first, time, deltaTime);
            }
            else
            {
                SpriterProcessor.UpdateFrameData(data, first, second, time, deltaTime, factor);
            }

            return data;
        }
    }
}
