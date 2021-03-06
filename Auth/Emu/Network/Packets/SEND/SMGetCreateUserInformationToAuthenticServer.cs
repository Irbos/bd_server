﻿using Auth.Emu.Enum;
using System;
using System.IO;

namespace Auth.Emu.Network.Packets.SEND
{
    [Message(MessageIds.SMGetCreateUserInformationToAuthenticServer, true)]
    public class SMGetCreateUserInformationToAuthenticServer : IMessage
    {
        public int accountid;
        public int pinenable;
        public void Serialize(BinaryWriter writer)
        {
            writer.Write(new byte[] {
                0x36, 0x00, 0x39, 0x00, 0x36,
0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,
0x40, 0x00, 0x0A, 0x00, 0x00, 0xD7, 0x88, 0x9B, 0x33, 0x01,
0x00, 0x00, 0x00, 0xC2, 0x21, 0x43, 0xDE, 0x00, 0x00, 0x00,
0x00, 0x68, 0x5A, 0x72, 0x2B, 0x00, 0x00, 0x00, 0x00, 0x40,
0xB4, 0xB7, 0xEF, 0x00, 0x00, 0x00, 0x00, 0xF0, 0xD0, 0x28,
0x73, 0x00, 0x00, 0x00, 0x00, 0xF9, 0x0A, 0xE9, 0xF5, 0x01,
0x00, 0x00, 0x00, 0xF1, 0x32, 0x44, 0x91, 0x00, 0x00, 0x00,
0x00, 0xD7, 0x17, 0xD8, 0x9D, 0x01, 0x00, 0x00, 0x00, 0xCA,
0x2E, 0x2D, 0xE7, 0x01, 0x00, 0x00, 0x00, 0x89, 0x17, 0x0C,
0x0C, 0x02, 0x00, 0x00, 0x00, 0x74, 0x25, 0xAA, 0x1B, 0x01,
0x00, 0x00, 0x00, 0x0A, 0x41, 0x65, 0xC6, 0x01, 0x00, 0x00,
0x00, 0xFF, 0xDF, 0x21, 0xEE, 0x01, 0x00, 0x00, 0x00, 0xCE,
0xBA, 0xE0, 0xEC, 0x00, 0x00, 0x00, 0x00, 0xC6, 0xF5, 0x03,
0xFF, 0x01, 0x00, 0x00, 0x00, 0x8C, 0xBC, 0xED, 0xC7, 0x01,
0x00, 0x00, 0x00, 0x57, 0x2C, 0xEA, 0x97, 0x00, 0x00, 0x00,
0x00, 0x16, 0xCE, 0x88, 0x4A, 0x00, 0x00, 0x00, 0x00, 0xC5,
0x1C, 0x32, 0xE4, 0x01, 0x00, 0x00, 0x00, 0x9A, 0xA9, 0xDD,
0x9D, 0x01, 0x00, 0x00, 0x00
        });
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}