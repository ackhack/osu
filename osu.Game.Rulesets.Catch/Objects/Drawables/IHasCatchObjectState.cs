// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Bindables;
using osuTK.Graphics;

namespace osu.Game.Rulesets.Catch.Objects.Drawables
{
    /// <summary>
    /// Provides a visual state of a <see cref="PalpableCatchHitObject"/>.
    /// </summary>
    public interface IHasCatchObjectState
    {
        PalpableCatchHitObject HitObject { get; }
        Bindable<Color4> AccentColour { get; }
        Bindable<bool> HyperDash { get; }

        float Rotation { get; }
        float Scale { get; }
    }
}
