﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSALVL
{
    public struct Block
    {
		public Block(short ID) { this.ID = ID; }
        public short ID;
    }

    public struct Collision
    {
		public Collision(byte Modifier, byte Material, byte Shape, byte Unk)
		{
			this.Modifier = Modifier;
			this.Material = Material;
			this.Shape = Shape;
			this.Unk = Unk;
		}
        public byte Modifier;
        public byte Material;
        public byte Shape;
        public byte Unk;
    }

    public struct Decoration
    {
		public Decoration(short Tile, byte Unk, sbyte Group)
		{
			this.Tile = Tile;
			this.Unk = Unk;
			this.Group = Group;
		}
		public short Tile;
        public byte Unk;
        public sbyte Group;
    }

    public struct Stage
    {
		public Stage(uint Unk_1, uint Unk_2, string Unk_String, float Unk_3, float Unk_4, float Unk_5, float Unk_6, float Unk_7, float Unk_8, float Unk_9, float Unk_10, float Unk_11)
		{
			this.Unk_1 = Unk_1;
			this.Unk_2 = Unk_2;
			this.Unk_String = Unk_String;
			this.Unk_3 = Unk_3;
			this.Unk_4 = Unk_4;
			this.Unk_5 = Unk_5;
			this.Unk_6 = Unk_6;
			this.Unk_7 = Unk_7;
			this.Unk_8 = Unk_8;
			this.Unk_9 = Unk_9;
			this.Unk_10 = Unk_10;
			this.Unk_11 = Unk_11;
		}
		public uint Unk_1;
        public uint Unk_2;
        public string Unk_String;
        public float Unk_3;
        public float Unk_4;
        public float Unk_5;
        public float Unk_6;
        public float Unk_7;
        public float Unk_8;
        public float Unk_9;
        public float Unk_10;
        public float Unk_11;
    }
}
