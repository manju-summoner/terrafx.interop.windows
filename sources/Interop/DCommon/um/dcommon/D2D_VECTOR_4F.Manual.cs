// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.Tracing;

namespace TerraFX.Interop
{
    public partial struct D2D_VECTOR_4F : IEquatable<D2D_VECTOR_4F>
    {
        public static readonly D2D_VECTOR_4F DEFAULT = new D2D_VECTOR_4F(0.0f, 0.0f, 0.0f, 0.0f);

        public D2D_VECTOR_4F(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public bool Equals(D2D_VECTOR_4F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_VECTOR_4F other) && this == other;

        public override int GetHashCode() => HashCode.Combine(x, y, z, w);

        public static bool operator ==(D2D_VECTOR_4F left, D2D_VECTOR_4F right) =>
            left.x == right.x &&
            left.y == right.y &&
            left.z == right.z &&
            left.w == right.w;

        public static bool operator !=(D2D_VECTOR_4F left, D2D_VECTOR_4F right) =>
            left.x != right.x ||
            left.y != right.y ||
            left.z != right.z ||
            left.w != right.w;
    }
}