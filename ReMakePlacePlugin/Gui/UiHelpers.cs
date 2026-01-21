using Dalamud.Bindings.ImGui;
using Dalamud.Interface;
using Dalamud.Interface.Textures;
using ECommons.DalamudServices;
using System.Numerics;

namespace ReMakePlacePlugin.Gui;

public static class UiHelpers
{
    /// <summary>
    /// Draw an icon from the Dalamud api.
    /// </summary>
    /// <param name="icon"> Item id, must be below 65000</param>
    /// <param name="size"></param>
    public static void DrawIcon(ushort icon, Vector2 size)
    {
        if (icon < 65000)
        {
            var iconTexture = Svc.Texture.GetFromGameIcon(new GameIconLookup(icon));
            ImGui.Image(iconTexture.GetWrapOrEmpty().Handle, size);
        }
    }

    /// <summary>Make a button with both an icon and text.</summary>
    public static bool IconTextButton(FontAwesomeIcon icon, string text)
    {
        var iconSize = GetIconSize(icon);
        var textSize = ImGui.CalcTextSize(text);
        var padding = ImGui.GetStyle().FramePadding;
        var spacing = ImGui.GetStyle().ItemInnerSpacing;

        var buttonSizeX = iconSize.X + textSize.X + padding.X * 2 + spacing.X;
        var buttonSizeY = (iconSize.Y > textSize.Y ? iconSize.Y : textSize.Y) + padding.Y * 2;
        var buttonSize = new Vector2(buttonSizeX, buttonSizeY);

        var buttonClicked = ImGui.Button("###" + icon.ToIconString() + text, buttonSize);
        var cursorAfter = ImGui.GetCursorScreenPos();

        var itemMin = ImGui.GetItemRectMin();
        var contentHeight = iconSize.Y > textSize.Y ? iconSize.Y : textSize.Y;
        var contentPos = new Vector2(
            itemMin.X + padding.X,
            itemMin.Y + (buttonSizeY - contentHeight) * 0.5f
        );

        ImGui.SetCursorScreenPos(contentPos);
        ImGui.PushFont(UiBuilder.IconFont);
        ImGui.Text(icon.ToIconString());
        ImGui.PopFont();

        var textPos = new Vector2(contentPos.X + iconSize.X + spacing.X, contentPos.Y);
        ImGui.SetCursorScreenPos(textPos);
        ImGui.Text(text);
        ImGui.SetCursorScreenPos(cursorAfter);

        return buttonClicked;
    }

    /// <summary>Get the size of an icon.</summary>
    public static Vector2 GetIconSize(FontAwesomeIcon icon)
    {
        ImGui.PushFont(UiBuilder.IconFont);
        var iconSize = ImGui.CalcTextSize(icon.ToIconString());
        ImGui.PopFont();
        return iconSize;
    }
}
