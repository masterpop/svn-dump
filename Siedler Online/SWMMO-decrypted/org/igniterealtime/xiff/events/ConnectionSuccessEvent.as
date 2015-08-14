﻿package org.igniterealtime.xiff.events
{
    import flash.events.*;

    public class ConnectionSuccessEvent extends Event
    {
        public static const CONNECT_SUCCESS:String = "connection";

        public function ConnectionSuccessEvent()
        {
            super(CONNECT_SUCCESS, false, false);
            return;
        }// end function

        override public function toString() : String
        {
            return "[ConnectionSuccessEvent type=\"" + type + "\" bubbles=" + bubbles + " cancelable=" + cancelable + " eventPhase=" + eventPhase + "]";
        }// end function

        override public function clone() : Event
        {
            return new ConnectionSuccessEvent();
        }// end function

    }
}
