using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Doom.ContentTypes.Blocks
{
    [ContentType(DisplayName = "DoomBlock", GUID = "6df9dcae-319b-489b-9df0-2e9d3fc11cf0", Description = "")]
    public class DoomBlock : BlockData
    {
        public virtual bool RipAndTear{get;set;}   
    }
}