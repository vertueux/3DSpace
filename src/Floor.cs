// Copyright (c) Virtuous. Licensed under the MIT license.
// See LICENSE.md in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RenderingDemo
{
    class Floor 
    {
        private int floorWidth;
        private int floorLength;
        private VertexBuffer floorBuffer;
        private GraphicsDevice device;
        private Color[] floorColors = new Color[2] { Color.White, Color.DarkSlateBlue };

        public Floor(GraphicsDevice device, int width, int length)
        {
            this.device = device;
            this.floorWidth = width;
            this.floorLength = length;
            BuildFloorBuffer();
        }

        private void BuildFloorBuffer()
        {
            List<VertexPositionColor> vertextList = new List<VertexPositionColor>();
            int counter = 0;
            for (int x = 0; x < floorWidth; x++)
            {
                counter++;
                for (int z = 0; z < floorLength; z++)
                {
                    counter++;
                    foreach (VertexPositionColor vertex in FloorTile(x, z, floorColors[counter % 2]))
                    {
                        vertextList.Add(vertex);
                    }
                }
            }
            floorBuffer = new VertexBuffer(device, VertexPositionColor.VertexDeclaration, vertextList.Count, BufferUsage.None);
            floorBuffer.SetData<VertexPositionColor>(vertextList.ToArray());
        }

        private List<VertexPositionColor> FloorTile(int xOffset, int zOffset, Color tileColor)
        {
            List<VertexPositionColor> list = new List<VertexPositionColor>();
            list.Add(new VertexPositionColor(new Vector3(0 + xOffset, 0, 0 + zOffset), tileColor));
            list.Add(new VertexPositionColor(new Vector3(1 + xOffset, 0, 0 + zOffset), tileColor));
            list.Add(new VertexPositionColor(new Vector3(0 + xOffset, 0, 1 + zOffset), tileColor));
            list.Add(new VertexPositionColor(new Vector3(1 + xOffset, 0, 0 + zOffset), tileColor));
            list.Add(new VertexPositionColor(new Vector3(1 + xOffset, 0, 1 + zOffset), tileColor));
            list.Add(new VertexPositionColor(new Vector3(0 + xOffset, 0, 1 + zOffset), tileColor));
            return list;
        }

        public void Draw(Camera camera, BasicEffect effect)
        {
            effect.VertexColorEnabled = true;
            effect.View = camera.View;
            effect.Projection = camera.Projection;
            effect.World = Matrix.Identity;
            foreach (EffectPass pass in effect.CurrentTechnique.Passes)
            {
                pass.Apply();
                device.SetVertexBuffer(floorBuffer);
                device.DrawPrimitives(PrimitiveType.TriangleList, 0, floorBuffer.VertexCount / 3); // Triangle has 3 vertices.
            }
        }
    }
}
