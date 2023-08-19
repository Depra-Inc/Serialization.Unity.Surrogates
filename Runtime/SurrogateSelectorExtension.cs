// Copyright © 2022-2023 Nikolay Melnikov. All rights reserved.
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.Serialization;
using UnityEngine;

namespace Depra.Serialization.Surrogates.Runtime
{
	public static class SurrogateSelectorExtension
	{
		public static void AddAllUnitySurrogates(this SurrogateSelector surrogateSelector,
			StreamingContextStates contextStates = StreamingContextStates.All)
		{
			var streamingContext = new StreamingContext(contextStates);
			surrogateSelector.AddSurrogate(typeof(Color), streamingContext, new ColorSerializationSurrogate());
			surrogateSelector.AddSurrogate(typeof(Vector2), streamingContext, new Vector2SerializationSurrogate());
			surrogateSelector.AddSurrogate(typeof(Vector2Int), streamingContext, new Vector2IntSerializationSurrogate());
			surrogateSelector.AddSurrogate(typeof(Vector3), streamingContext, new Vector3SerializationSurrogate());
			surrogateSelector.AddSurrogate(typeof(Vector3Int), streamingContext, new Vector3IntSerializationSurrogate());
			surrogateSelector.AddSurrogate(typeof(Vector4), streamingContext, new Vector4SerializationSurrogate());
			surrogateSelector.AddSurrogate(typeof(Quaternion), streamingContext, new QuaternionSerializationSurrogate());
		}
	}
}