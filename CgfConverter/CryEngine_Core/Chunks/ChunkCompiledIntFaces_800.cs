﻿using System.IO;
using System.Linq;

namespace CgfConverter.CryEngineCore
{
    public class ChunkCompiledIntFaces_800 : ChunkCompiledIntFaces
    {
        public override void Read(BinaryReader b)
        {
            base.Read(b);
            NumIntFaces = this.DataSize / 6;        // This is an array of TFaces, which are 3 uint16.
            Faces = new TFace[NumIntFaces];
            for (int i = 0; i < NumIntFaces; i++)
            {
                Faces[i].i0 = b.ReadUInt16();
                Faces[i].i1 = b.ReadUInt16();
                Faces[i].i2 = b.ReadUInt16();
            }
            SkinningInfo skin = GetSkinningInfo();
            skin.IntFaces = Faces.ToList();
        }
    }
}
