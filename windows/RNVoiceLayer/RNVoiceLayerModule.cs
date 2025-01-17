using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Voice.Layer.RNVoiceLayer
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNVoiceLayerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNVoiceLayerModule"/>.
        /// </summary>
        internal RNVoiceLayerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNVoiceLayer";
            }
        }
    }
}
