﻿package 
{
    import GUI.Components.ItemRenderer.*;
    import flash.display.*;
    import mx.binding.*;
    import mx.core.*;

    public class _GUI_Components_ItemRenderer_ShopItemRendererWatcherSetupUtil extends Sprite implements IWatcherSetupUtil
    {

        public function _GUI_Components_ItemRenderer_ShopItemRendererWatcherSetupUtil()
        {
            return;
        }// end function

        public function setup(param1:Object, param2:Function, param3:Array, param4:Array) : void
        {
            return;
        }// end function

        public static function init(param1:IFlexModuleFactory) : void
        {
            ShopItemRenderer.watcherSetupUtil = new _GUI_Components_ItemRenderer_ShopItemRendererWatcherSetupUtil;
            return;
        }// end function

    }
}
