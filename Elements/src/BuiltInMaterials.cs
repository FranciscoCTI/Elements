using System;
using Elements.Geometry;

namespace Elements
{
    /// <summary>
    /// Built in materials.
    /// </summary>
    public static class BuiltInMaterials
    {
        /// <summary>
        /// Glass.
        /// </summary>
        public static Material Glass { get; } = new Material("glass", new Color(1.0f, 1.0f, 1.0f, 0.2f), 1.0f, 1.0f, null, false, false, id: Guid.Parse("28c5c2b1-d65c-4c46-8689-d651f50f07e7"));

        /// <summary>
        /// Steel.
        /// </summary>
        public static Material Steel { get; } = new Material("steel", new Color(0.6f, 0.5f, 0.5f, 1.0f), 0.1f, 0.4f, null, false, false, id: Guid.Parse("13bef3c8-64c5-4283-a471-2571239cc14d"));

        /// <summary>
        /// The default material.
        /// </summary>
        public static Material Default { get; } = new Material("default", new Color(1.0f, 1.0f, 1.0f, 1.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("9babb829-9b96-4e73-97f4-9658d4d6c31c"));

        /// <summary>
        /// Concrete.
        /// </summary>
        public static Material Concrete { get; } = new Material("concrete", new Color(0.5f, 0.5f, 0.5f, 1.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("e7492160-3d9c-4fde-83a9-618abd381169"));

        /// <summary>
        /// Default material used to represent masses.
        /// </summary>
        public static Material Mass { get; } = new Material("mass", new Color(0.5f, 0.5f, 1.0f, 0.2f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("323c9495-d84e-4c57-b5af-a2e9fd1a8a19"));

        /// <summary>
        /// Wood.
        /// </summary>
        public static Material Wood { get; } = new Material("wood", new Color(224f / 255f, 206f / 255f, 155f / 255f, 1.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("f6fa27a7-dbe1-4bcf-823c-3d6d3c34876d"));

        /// <summary>
        /// Black
        /// </summary>
        public static Material Black { get; } = new Material("black", new Color(0.0f, 0.0f, 0.0f, 1.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("7298d643-9049-4a2b-960d-ae775b50fd80"));

        /// <summary>
        /// Edges
        /// </summary>
        public static Material Edges { get; } = new Material("edges", new Color(0.1f, 0.1f, 0.1f, 1.0f), 0.0f, 0.0f, null, true, false, id: Guid.Parse("d0c7a361-f32f-4fae-bd39-c1abc56b4b6f"));

        /// <summary>
        /// Points
        /// </summary>
        public static Material Points { get; } = new Material("points", new Color(1.0f, 0.0f, 0.0f, 1.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("9f4c28e7-a140-4b4a-85f5-3551d468e921"));

        /// <summary>
        /// Topography
        /// </summary>
        public static Material Topography { get; } = new Material("topography", new Color(0.59f, 0.59f, 0.39f, 1.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("ab838896-b7ef-43a2-afac-f3294153b3db"));

        /// <summary>
        /// Edges Highlighted
        /// </summary>
        public static Material EdgesHighlighted { get; } = new Material("edge_highlighted", new Color(1.0f, 1.0f, 0.0f, 1.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("43bbbd67-bb4d-4f66-a69b-40b5ae772db6"));

        /// <summary>
        /// Void
        /// </summary>
        public static Material Void { get; } = new Material("void", new Color(Colors.Lime.Red, Colors.Lime.Green, Colors.Lime.Blue, 0.1f), 0.1f, 0.1f, null, false, false, id: Guid.Parse("f616193d-6cca-42bc-b0d8-ccdc4f457693"));

        /// <summary>
        /// X Axis
        /// </summary>
        public static Material XAxis { get; } = new Material("X", new Color(1.0f, 0.0f, 0.0f, 1.0f), 0.1f, 0.1f, null, true, false, id: Guid.Parse("a7059e89-d331-401b-9cd9-9f77b281f068"));

        /// <summary>
        /// Y Axis
        /// </summary>
        public static Material YAxis { get; } = new Material("Y", new Color(0.0f, 1.0f, 0.0f, 1.0f), 0.1f, 0.1f, null, true, false, id: Guid.Parse("30ab5b47-7ef8-4376-98c1-8d58f3c61c5f"));

        /// <summary>
        /// Z Axis
        /// </summary>
        public static Material ZAxis { get; } = new Material("Z", new Color(0.0f, 0.0f, 1.0f, 1.0f), 0.1f, 0.1f, null, true, false, id: Guid.Parse("0dd0b2da-f4ca-47c5-a50e-6d4f8b044c36"));

        /// <summary>
        /// Fully transparent material.
        /// </summary>
        public static Material Trans { get; } = new Material("trans", new Color(0.0f, 0.0f, 0.0f, 0.0f), 0.0f, 0.0f, null, false, false, id: Guid.Parse("0af9722a-3bbc-4731-aaff-1d023e02b573"));
    }
}