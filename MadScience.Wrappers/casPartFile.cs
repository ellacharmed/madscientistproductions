﻿using System;
using System.Collections;
//using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using OX.Copyable;
//using Gibbed.Helpers;

namespace MadScience
{
    public class casPartFile
    {
        public casPart cFile = new casPart();
        private StringBuilder sb = new StringBuilder();

        private void avSB(string keyName, string value)
        {
            sb.Append("<value key=\"" + keyName + "\" value=\"" + value + "\" />");
        }

        private void avSBL(string keyName, string value)
        {
            sb.AppendLine("<value key=\"" + keyName + "\" value=\"" + value + "\" />");
        }

        private void addLine(casPart casP, string keyName, string value)
        {
            addLine(casP, keyName, value, false);
        }

        private void addLine(casPart casP, string keyName, string value, bool addToKeylist)
        {
            if (!String.IsNullOrEmpty(value))
            {
                Console.WriteLine("Adding " + keyName);
                if (addToKeylist) addToTGI(casP, new MadScience.Wrappers.ResourceKey(value));
                avSB(keyName, value);
            }
        }

        private void addToTGI(casPart casP, MadScience.Wrappers.ResourceKey tgiNew)
        {
            // Remove duplicates from the tgi64list (just in case)
            bool hasTGI = false;
                for (int k = 0; k < casP.tgi64list.Count; k++)
                {
                    MadScience.Wrappers.ResourceKey tgi = casP.tgi64list[k];
                    if (tgi.typeId == tgiNew.typeId && tgi.groupId == tgiNew.groupId && tgi.instanceId == tgiNew.instanceId)
                    {
                        hasTGI = true;
                        break;
                    }
                }
                if (!hasTGI)
                {
                    Console.WriteLine("Adding tgi64 " + tgiNew.ToString());
                    casP.tgi64list.Add(tgiNew);
                }
            
        }

		public string ageGender()
		{
			return ageGender(this.cFile.ageGenderFlag);
		}

		public string ageGender(uint ageGenderFlag)
		{
			string retString = "";
			if ((ageGenderFlag & 0x1) == 0x1) { retString += "b"; this.cFile.ageGender.baby = true;  }
			if ((ageGenderFlag & 0x2) == 0x2) { retString += "p"; this.cFile.ageGender.toddler = true; }
			if ((ageGenderFlag & 0x4) == 0x4) { retString += "c"; this.cFile.ageGender.child = true; }
			if ((ageGenderFlag & 0x8) == 0x8) { retString += "t"; this.cFile.ageGender.teen = true; }
			if ((ageGenderFlag & 0x10) == 0x10) { retString += "y"; this.cFile.ageGender.youngAdult = true; }
			if ((ageGenderFlag & 0x20) == 0x20) { retString += "a"; this.cFile.ageGender.adult = true; }
			if ((ageGenderFlag & 0x40) == 0x40) { retString += "e"; this.cFile.ageGender.elder = true; }
			if ((ageGenderFlag & 0x1000) == 0x1000) { retString += "m"; this.cFile.ageGender.male = true; }
			if ((ageGenderFlag & 0x2000) == 0x2000) { retString += "f"; this.cFile.ageGender.female = true; }

			return retString;
		}

		public string casType()
		{
			return casType(this.cFile.typeFlag);
		}

		public string casType(uint typeFlag)
		{
			string retString = "";
			if ((typeFlag & 0x1) == 0x1) retString = "Hair";
			if ((typeFlag & 0x2) == 0x2) retString = "Scalp";
			if ((typeFlag & 0x4) == 0x4) retString = "Face Overlay";
			if ((typeFlag & 0x8) == 0x8) retString = "Body";
			if ((typeFlag & 0x10) == 0x10) retString = "Accessory";
			return retString;
		}

		public string clothingType()
		{
			return clothingType(this.cFile.clothingType);
		}

		public string clothingType(uint clothingType)
		{
			string retString = "";

			switch (clothingType)
			{
				case 1: retString = "Hair"; break;
				case 2: retString = "Scalp"; break;
				case 3: retString = "Face"; break;
				case 4: retString = "Body"; break;
				case 5: retString = "Top"; break;
				case 6: retString = "Bottom"; break;
				case 7: retString = "Shoes"; break;
				case 11: retString = "Earrings"; break;
				case 12: retString = "Glasses (F)"; break;
				case 13: retString = "Bracelets"; break;
				case 14: retString = "Ring (Left)"; break;
				case 15: retString = "Ring (Right)"; break;
				case 16: retString = "Beard"; break;
				case 17: retString = "Lipstick"; break;
				case 18: retString = "Eyeshadow"; break;
				case 19: retString = "Eyeliner"; break;
				case 20: retString = "Blush"; break;
				case 21: retString = "Makeup"; break;
				case 22: retString = "Eyebrow"; break;
				case 24: retString = "Glove"; break;
				case 25: retString = "Socks"; break;
				case 26: retString = "Mascara"; break;
				case 29: retString = "Weathering"; break;
				case 30: retString = "Earring (Left)"; break;
				case 31: retString = "Earring (Right)"; break;
			}

			return retString;
		}

		public string clothingCategory()
		{
			return clothingCategory(this.cFile.clothingCategory);	
		}

		public string clothingCategory(uint clothingCategory)
		{

			string retString = "";
			if ((clothingCategory & 0x1) == 0x1) retString += "Naked ";
			if ((clothingCategory & 0x2) == 0x2) retString += "Everyday ";
			if ((clothingCategory & 0x4) == 0x4) retString += "Formalwear ";
			if ((clothingCategory & 0x8) == 0x8) retString += "Sleepwear ";
			if ((clothingCategory & 0x10) == 0x10) retString += "Swimwear ";
			if ((clothingCategory & 0x20) == 0x20) retString += "Athletic ";
			if ((clothingCategory & 0x40) == 0x40) retString += "Singed ";
			if ((clothingCategory & 0x100) == 0x100) retString += "Career ";
			if ((clothingCategory & 0xFFFF) == 0xFFFF) retString += "All ";
			return retString;

		}

        public string generateXMLChunk(casPart casP, int chunkNo, bool addComments)
        {
            sb = new StringBuilder();

            if (addComments) sb.Append("<!-- XML generated by CTU -->");

            xmlChunkDetails chunk = (xmlChunkDetails)casP.xmlChunk[chunkNo];
            sb.Append("<preset>");
            sb.Append("<complate name=\"" + chunk.name + "\" reskey=\"" + chunk.reskey + "\">");
            avSB("assetRoot", "X:");
            addLine(casP, "daeFileName", chunk.daeFileName);

            addLine(casP, "age", chunk.age);
            addLine(casP, "gender", chunk.gender);
            addLine(casP, "bodyType", chunk.bodyType);
            addLine(casP, "partType", chunk.partType);
            addLine(casP, "filename", chunk.filename);
            addLine(casP, "IsHat", chunk.IsHat);

            addLine(casP, "DrawsOnFace", chunk.DrawsOnFace);
            addLine(casP, "DrawsOnScalp", chunk.DrawsOnScalp);

            addLine(casP, "Overlay", chunk.Overlay, true);
            addLine(casP, "Control Map", chunk.ControlMap, true);
            addLine(casP, "Diffuse Map", chunk.DiffuseMap, true);

            addLine(casP, "Clothing Specular", chunk.ClothingSpecular, true);
            addLine(casP, "Clothing Ambient", chunk.ClothingAmbient, true);

            addLine(casP, "Rotation", chunk.Rotation);

            // Hair
            addLine(casP, "Root Color", chunk.hair.RootColor);
            addLine(casP, "Diffuse Color", chunk.hair.DiffuseColor);
            addLine(casP, "Highlight Color", chunk.hair.HighlightColor);
            addLine(casP, "Tip Color", chunk.hair.TipColor);

            // Hair
            addLine(casP, "Scalp Diffuse Map", chunk.hair.ScalpDiffuseMap, true);
            addLine(casP, "Scalp Control Map", chunk.hair.ScalpControlMap, true);
            addLine(casP, "Scalp Specular Map", chunk.hair.ScalpSpecularMap, true);
            addLine(casP, "Scalp AO", chunk.hair.ScalpAO, true);
            addLine(casP, "Face Diffuse Map", chunk.hair.FaceDiffuseMap, true);
            addLine(casP, "Face Control Map", chunk.hair.FaceControlMap, true);
            addLine(casP, "Face Specular Map", chunk.hair.FaceSpecularMap, true);
            addLine(casP, "Face AO", chunk.hair.FaceAO, true);

            addLine(casP, "Mask", chunk.Mask, true);
            addLine(casP, "MaskHeight", chunk.MaskHeight);
            addLine(casP, "MaskWidth", chunk.MaskWidth);

            addLine(casP, "Multiplier", chunk.Multiplier, true);

            addLine(casP, "Tint Color", chunk.TintColor);
            addLine(casP, "Tint Color A", chunk.tint.A.color);
            addLine(casP, "Tint Color B", chunk.tint.B.color);
            addLine(casP, "Tint Color C", chunk.tint.C.color);
            addLine(casP, "Tint Color D", chunk.tint.D.color);
            addLine(casP, "Tint Color A Enabled", chunk.tint.A.enabled);
            addLine(casP, "Tint Color B Enabled", chunk.tint.B.enabled);
            addLine(casP, "Tint Color C Enabled", chunk.tint.C.enabled);
            addLine(casP, "Tint Color D Enabled", chunk.tint.D.enabled);

            addLine(casP, "Face Overlay", chunk.faceOverlay, true);
            addLine(casP, "Face Specular", chunk.faceSpecular, true);


            if (addComments) sb.Append("<!-- Did you get the satellite photos yet? -->");

            for (int i = 0; i < 4; i++)
            {
                if (!String.IsNullOrEmpty(chunk.pattern[i].name))
                {
                    string patternName = "";
                    string charName;
                    switch (i)
                    {
                        case 0: patternName = "Pattern A"; charName = "JackB"; break;
                        case 1: patternName = "Pattern B"; charName = "ChloeON"; break;
                        case 2: patternName = "Pattern C"; charName = "TonyA"; break;
                        case 3: patternName = "Pattern D"; charName = "BillB"; break;
                    }

                    avSB(patternName, chunk.pattern[i].nameHigh);
                    avSB(patternName + " Enabled", chunk.pattern[i].Enabled);
                    avSB(patternName + " Linked", chunk.pattern[i].Linked);
                    avSB(patternName + " Tiling", chunk.pattern[i].Tiling);
                }
            }

            addLine(casP, "Stencil A", chunk.stencil.A.key, true);
            addLine(casP, "Stencil B", chunk.stencil.B.key, true);
            addLine(casP, "Stencil C", chunk.stencil.C.key, true);
            addLine(casP, "Stencil D", chunk.stencil.D.key, true);
            addLine(casP, "Stencil E", chunk.stencil.E.key, true);
            addLine(casP, "Stencil F", chunk.stencil.F.key, true);

            addLine(casP, "Stencil A Tiling", chunk.stencil.A.Tiling);
            addLine(casP, "Stencil B Tiling", chunk.stencil.B.Tiling);
            addLine(casP, "Stencil C Tiling", chunk.stencil.C.Tiling);
            addLine(casP, "Stencil D Tiling", chunk.stencil.D.Tiling);
            addLine(casP, "Stencil E Tiling", chunk.stencil.E.Tiling);
            addLine(casP, "Stencil F Tiling", chunk.stencil.F.Tiling);

            addLine(casP, "Stencil A Rotation", chunk.stencil.A.Rotation);
            addLine(casP, "Stencil B Rotation", chunk.stencil.B.Rotation);
            addLine(casP, "Stencil C Rotation", chunk.stencil.C.Rotation);
            addLine(casP, "Stencil D Rotation", chunk.stencil.D.Rotation);
            addLine(casP, "Stencil E Rotation", chunk.stencil.E.Rotation);
            addLine(casP, "Stencil F Rotation", chunk.stencil.F.Rotation);

            addLine(casP, "Stencil A Enabled", chunk.stencil.A.Enabled);
            addLine(casP, "Stencil B Enabled", chunk.stencil.B.Enabled);
            addLine(casP, "Stencil C Enabled", chunk.stencil.C.Enabled);
            addLine(casP, "Stencil D Enabled", chunk.stencil.D.Enabled);
            addLine(casP, "Stencil E Enabled", chunk.stencil.E.Enabled);
            addLine(casP, "Stencil F Enabled", chunk.stencil.F.Enabled);

            if (addComments) sb.Append("<!-- Damnit! -->");

            addLine(casP, "IsNaked", chunk.IsNaked);
            addLine(casP, "IsNotNaked", chunk.IsNotNaked);

            addLine(casP, "Skin Specular", chunk.SkinSpecular, true);
            addLine(casP, "Skin Ambient", chunk.SkinAmbient, true);


            addLine(casP, "Logo UpperLeft", chunk.logo.upperLeft);
            addLine(casP, "Logo LowerRight", chunk.logo.lowerRight);
            addLine(casP, "Logo", chunk.logo.filename);
            addLine(casP, "Logo Enabled", chunk.logo.enabled);

            addLine(casP, "Part Mask", chunk.PartMask, true);

            if (addComments) sb.Append("<!-- We are running out of lime! -->");
            casP.tgi64list.Add(new MadScience.Wrappers.ResourceKey(chunk.reskey));

            for (int i = 0; i < 4; i++)
            {
                if (chunk.pattern[i].name != "")
                {
                    string patternName = "";
                    string charName = "";
                    switch (i)
                    {
                        case 0: patternName = "Pattern A"; charName = "JackB"; break;
                        case 1: patternName = "Pattern B"; charName = "ChloeON"; break;
                        case 2: patternName = "Pattern C"; charName = "TonyA"; break;
                        case 3: patternName = "Pattern D"; charName = "BillB"; break;
                    }

                    sb.AppendLine("<pattern name=\"" + chunk.pattern[i].name + "\" reskey=\"" + chunk.pattern[i].key + "\" variable=\"" + patternName + "\">");
                    //casP.tgi64list.Add(new keyName(chunk.pattern[i].key).ToTGI());
                    casP.tgi64list.Add(new MadScience.Wrappers.ResourceKey(chunk.pattern[i].key));
                    if (addComments) sb.Append("<!-- " + charName + "-->");
                    avSBL("assetRoot", "X:");

                    if (chunk.pattern[i].type == "solidColor")
                    {
                        avSBL("Color", chunk.pattern[i].Color);
                    }
                    if (chunk.pattern[i].type == "HSV")
                    {
                        if (!String.IsNullOrEmpty(chunk.pattern[i].BackgroundImage))
                        {
                            casP.tgi64list.Add(new MadScience.Wrappers.ResourceKey(chunk.pattern[i].BackgroundImage));
                            avSBL("Background Image", chunk.pattern[i].BackgroundImage);
                        }
                        if (!String.IsNullOrEmpty(chunk.pattern[i].HBg)) avSBL("H Bg", chunk.pattern[i].HBg);
                        if (!String.IsNullOrEmpty(chunk.pattern[i].SBg)) avSBL("S Bg", chunk.pattern[i].SBg);
                        if (!String.IsNullOrEmpty(chunk.pattern[i].VBg)) avSBL("V Bg", chunk.pattern[i].VBg);
                        if (!String.IsNullOrEmpty(chunk.pattern[i].BaseHBg)) avSBL("Base H Bg", chunk.pattern[i].BaseHBg);
                        if (!String.IsNullOrEmpty(chunk.pattern[i].BaseSBg)) avSBL("Base S Bg", chunk.pattern[i].BaseSBg);
                        if (!String.IsNullOrEmpty(chunk.pattern[i].BaseVBg)) avSBL("Base V Bg", chunk.pattern[i].BaseVBg);
                        if (!String.IsNullOrEmpty(chunk.pattern[i].HSVShiftBg)) avSBL("HSVShift Bg", chunk.pattern[i].HSVShiftBg);
                    }
                    if (chunk.pattern[i].type == "Coloured")
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (!String.IsNullOrEmpty(chunk.pattern[i].ColorP[j])) avSBL("Color " + j.ToString(), chunk.pattern[i].ColorP[j]);
                        }
                    }

                    if (!String.IsNullOrEmpty(chunk.pattern[i].rgbmask)) avSBL("rgbmask", chunk.pattern[i].rgbmask);
                    if (!String.IsNullOrEmpty(chunk.pattern[i].specmap)) avSBL("specmap", chunk.pattern[i].specmap);
                    avSBL("filename", chunk.pattern[i].filename);
                    sb.AppendLine("</pattern>");
                }
            }

            if (!String.IsNullOrEmpty(chunk.logo.name))
            {
                sb.Append("<pattern name=\"" + chunk.logo.name + "\" reskey=\"" + chunk.logo.key + "\" variable=\"Logo\">");
                casP.tgi64list.Add(new MadScience.Wrappers.ResourceKey(chunk.logo.key));
                avSB("assetRoot", "X:");
                //avSB("Color", chunk.pattern.Logo.Color);
                avSB("filename", chunk.logo.filename);
                sb.Append("</pattern>");
            }
            sb.Append("</complate>");
            if (addComments) sb.Append("<!-- Have you seen my daughter?! -->");
            sb.Append("</preset>");

            return sb.ToString();
        }

        public void Save(Stream casFile, casPart casP)
        {
            Save(casFile, casP, true);
        }

        public void Save(Stream casFile, casPart casP, bool addComments)
        {

            int xmlSize = 0;
            int chunkCount = 0;
            //ArrayList newtgi64 = new ArrayList();

            if (casP.xmlChunk != null)
            {

                // Remove the textures and XML from the tgi64 list
                List<MadScience.Wrappers.ResourceKey> temp = new List<MadScience.Wrappers.ResourceKey>();
                for (int j = 0; j < casP.tgi64list.Count; j++)
                {
                    //tgi64 tgi = (tgi64)casP.tgi64list[j];
                    MadScience.Wrappers.ResourceKey tgi = casP.tgi64list[j];
                    switch (tgi.typeId)
                    {
                        case 0x00B2D882:
                        case 0x0333406C:
                            break;
                        default:
                            temp.Add(tgi);
                            break;
                    }
                }

                casP.tgi64list.Clear();

                // Make up the XML chunks first
                for (int j = 0; j < casP.xmlChunk.Count; j++)
                {

                    chunkCount++;
                    
                    casP.xmlChunkRaw[j] = generateXMLChunk(casP, j, addComments);

                }

                for (int j = 0; j < temp.Count; j++)
                {
                    casP.tgi64list.Add(temp[j]);
                }

            }
            else
            {
                chunkCount = 0;
                //newtgi64 = casP.tgi64list;    
            }

            // Okay remove any possible duplicates from the tgi list
            List<MadScience.Wrappers.ResourceKey> newTGIs = new List<MadScience.Wrappers.ResourceKey>();
            for (int i = 0; i < casP.tgi64list.Count; i++)
            {
                bool hasMatch = false;
                MadScience.Wrappers.ResourceKey srcTgi = casP.tgi64list[i];

                for (int j = 0; j < newTGIs.Count; j++)
                {
                    MadScience.Wrappers.ResourceKey dstTgi = newTGIs[j];

                    if (srcTgi.typeId == dstTgi.typeId && srcTgi.groupId == dstTgi.groupId && srcTgi.instanceId == dstTgi.instanceId)
                    {
                        hasMatch = true;
                        break;
                    }
                }
                if (!hasMatch) newTGIs.Add(srcTgi);

            }

            casP.tgi64list = newTGIs;

            BinaryWriter writer = new BinaryWriter(casFile);
            // Version is always 18
            uint casPversion = 18;            
            writer.Write(casPversion);
            writer.Write(xmlSize);

            writer.Write(chunkCount);

            if (chunkCount > 0)
            {
                for (int i = 1; i <= casP.xmlChunk.Count; i++)
                {
                    string temp = (string)casP.xmlChunkRaw[i - 1];
                    writer.Write(temp.Length);
                    MadScience.StreamHelpers.WriteStringUTF16(casFile, true, temp);
                    writer.Write(i);
                }
            }

            writer.Write((byte)(casP.meshName.Length * 2));
            MadScience.StreamHelpers.WriteStringUTF16(casFile, false, casP.meshName);
            writer.Write(casP.clothingOrder);
            writer.Write(casP.unk2);
            writer.Write(casP.clothingType);
            writer.Write(casP.typeFlag);
            writer.Write(casP.ageGenderFlag);
            writer.Write(casP.clothingCategory);

            casP.tgiIndexBodyPart1 = (byte)findChunkInTGIList(casP, 0x034AEECB, 1);
            if (casP.tgiIndexBodyPart1 == 0) { casP.tgiIndexBodyPart1 = (byte)findChunkInTGIList(casP, 0x0, 1); }
            // If we still dont have a match... add a blank entry to the end.
            if (casP.tgiIndexBodyPart1 == 0)
            {
                casP.tgi64list.Add(new MadScience.Wrappers.ResourceKey());
                casP.tgiIndexBodyPart1 = (byte)(casP.tgi64list.Count - 1);
            }
            casP.tgiIndexBodyPart2 = (byte)findChunkInTGIList(casP, 0x034AEECB, 2);
            if (casP.tgiIndexBodyPart2 == 0) { casP.tgiIndexBodyPart2 = (byte)findChunkInTGIList(casP, 0x0, 1); }

            writer.Write(casP.tgiIndexBodyPart1);
            writer.Write(casP.tgiIndexBodyPart2);

            casP.tgiIndexBlendInfoFat = (byte)findChunkInTGIList(casP, 0x062C8204, 1);
            casP.tgiIndexBlendInfoFit = (byte)findChunkInTGIList(casP, 0x062C8204, 2);
            casP.tgiIndexBlendInfoThin = (byte)findChunkInTGIList(casP, 0x062C8204, 3);
            casP.tgiIndexBlendInfoSpecial = (byte)findChunkInTGIList(casP, 0x062C8204, 4);

            writer.Write(casP.tgiIndexBlendInfoFat);
            writer.Write(casP.tgiIndexBlendInfoFit);
            writer.Write(casP.tgiIndexBlendInfoThin);
            writer.Write(casP.tgiIndexBlendInfoSpecial);

            writer.Write(casP.unk5);

            if (casP.tgiIndexVPXY > 0)
            {
                casP.tgiIndexVPXY = (byte)findChunkInTGIList(casP, 0x736884F1, 1);

                writer.Write((byte)1);
                writer.Write(casP.tgiIndexVPXY);
            }
            else
            {
                writer.Write((byte)0);
            }

            writer.Write(casP.count2);
            for (int i = 0; i < casP.count2; i++)
            {
                unkRepeat uR = (unkRepeat)casP.count2repeat[i];
                writer.Write(uR.unkNum);
                writer.Write(uR.unk2);
                writer.Write(uR.unkRepeatInnerCount);
                for (int j = 0; j < uR.unkRepeatInnerCount; j++)
                {
                    intTriple iT = (intTriple)uR.unkRepeatInnerLoop[j];
                    writer.Write(iT.one);
                    writer.Write(iT.two);
                    writer.Write(iT.three);
                }

            }

            if (casP.tgiIndexDiffuse > 0)
            {
                casP.tgiIndexDiffuse = (byte)findChunkInTGIList(casP, 0x033A1435, 1);
                writer.Write((byte)1);
                writer.Write(casP.tgiIndexDiffuse);
            }
            else
            {
                writer.Write((byte)0);
            }
            if (casP.tgiIndexSpecular > 0)
            {
                casP.tgiIndexSpecular = (byte)findChunkInTGIList(casP, 0x033A1435, 2);
                writer.Write((byte)1);
                writer.Write(casP.tgiIndexSpecular);
            }
            else
            {
                writer.Write((byte)0);
            }

            // Diffuse files
            writer.Write(casP.count3);
            // WARNING: Assume 2 for now
            if (casP.count3 == 2)
            {
                byte c3r = (byte)findChunkInTGIList(casP, 0x033A1435, 3);
                writer.Write(c3r);
                c3r = (byte)findChunkInTGIList(casP, 0x033A1435, 4);
                writer.Write(c3r);
            }
            else
            {
                for (int i = 0; i < casP.count3; i++)
                {
                    byte c3r = (byte)casP.count3repeat[i];
                    writer.Write(c3r);
                }
            }

            // Specular files
            writer.Write(casP.count4);
            // WARNING: Assume 2 for now
            if (casP.count4 == 2)
            {
                byte c3r = (byte)findChunkInTGIList(casP, 0x033A1435, 5);
                writer.Write(c3r);
                c3r = (byte)findChunkInTGIList(casP, 0x033A1435, 6);
                writer.Write(c3r);
            } else {
                for (int i = 0; i < casP.count4; i++)
                {
                    byte c4r = (byte)casP.count4repeat[i];
                    writer.Write(c4r);
                }
                
            }

            writer.Write(casP.count5);
            // Construct the count5repeat based on the last X 0355E0A6 TGI refs
            for (int i = 0; i < casP.count5; i++)
            {
                byte c5r = (byte)findChunkInTGIList(casP, 0x0355E0A6, (i + 1));
                if (c5r == 0)
                {
                    // Find the first blank key
                    c5r = (byte)findChunkInTGIList(casP, 0x0, 1);
                }
                writer.Write(c5r);
            }

            writer.Write((byte)(casP.unkString.Length * 2));
            MadScience.StreamHelpers.WriteStringUTF16(casFile, false, casP.unkString);

            int tgiPos = (int)casFile.Position - 8;

            casP.count6 = (byte)newTGIs.Count;
            writer.Write(casP.count6);
            for (int i = 0; i < casP.count6; i++)
            {
                MadScience.Wrappers.ResourceKey tgi = newTGIs[i];
                Console.WriteLine("Writing tgi64 " + tgi.ToString());
                writer.Write(tgi.instanceId);
                writer.Write(tgi.groupId);
                writer.Write(tgi.typeId);
            }

            casFile.Seek(4, SeekOrigin.Begin);
            writer.Write(tgiPos);

        }

        private int findChunkInTGIList(casPart casP, uint typeId, int counter)
        {
            int temp = 0;
            int curCount = 0;
            for (int i = 0; i < casP.tgi64list.Count; i++)
            {
                MadScience.Wrappers.ResourceKey tgi = casP.tgi64list[i];
                if (tgi.typeId == typeId)
                {
                    curCount++;
                    if (curCount == counter)
                    {
                        temp = i;
                        break;
                    }
                }
            }
            return temp;
        }

		public casPart Load(Stream casFile)
		{
			return Load(casFile, true);
		}

		public casPart Load(Stream casFile, bool parseXML)
        {

            BinaryReader reader = new BinaryReader(casFile);

            cFile.version = reader.ReadUInt32();
            cFile.offset = reader.ReadUInt32();

            cFile.numParts = reader.ReadUInt32();

            for (int i = 0; i < cFile.numParts; i++)
            {
                uint xmlSize = reader.ReadUInt32();
                cFile.xmlChunkRaw.Add(MadScience.StreamHelpers.ReadStringUTF16(casFile, (xmlSize * 2)));
				if (parseXML) this.parseRawXML(cFile.xmlChunkRaw.Count);
                uint xmlNum = reader.ReadUInt32();
            }

            byte meshStringSize = reader.ReadByte();
            cFile.meshName = MadScience.StreamHelpers.ReadStringUTF16(casFile, false, (uint)meshStringSize);

            cFile.clothingOrder = reader.ReadSingle();
            cFile.unk2 = reader.ReadByte();

            cFile.clothingType = reader.ReadUInt32();

            cFile.typeFlag = reader.ReadUInt32();
            cFile.ageGenderFlag = reader.ReadUInt32();

			// Pre-populate the age/gender values
			this.ageGender(cFile.ageGenderFlag);

            cFile.clothingCategory = reader.ReadUInt32();

            cFile.tgiIndexBodyPart1 = reader.ReadByte();
            cFile.tgiIndexBodyPart2 = reader.ReadByte();
            cFile.tgiIndexBlendInfoFat = reader.ReadByte();
            cFile.tgiIndexBlendInfoFit = reader.ReadByte();
            cFile.tgiIndexBlendInfoThin = reader.ReadByte();
            cFile.tgiIndexBlendInfoSpecial = reader.ReadByte();

            cFile.unk5 = reader.ReadUInt32();

            byte hasIndexVPXY = reader.ReadByte();
            if (hasIndexVPXY == 1)
            {
                cFile.tgiIndexVPXY = reader.ReadByte();
            }

            cFile.count2 = reader.ReadByte();
            for (int i = 0; i < cFile.count2; i++)
            {
                unkRepeat uR = new unkRepeat();
                uR.unkNum = reader.ReadByte();
                uR.unk2 = reader.ReadUInt32();
                uR.unkRepeatInnerCount = reader.ReadByte();
                for (int j = 0; j < uR.unkRepeatInnerCount; j++)
                {
                    intTriple iT = new intTriple();
                    iT.one = reader.ReadUInt32();
                    iT.two = reader.ReadUInt32();
                    iT.three = reader.ReadUInt32();
                    uR.unkRepeatInnerLoop.Add(iT);
                }
                cFile.count2repeat.Add(uR);
            }

            byte hasIndexDiffuse = reader.ReadByte();
            if (hasIndexDiffuse == 1)
            {
                cFile.tgiIndexDiffuse = reader.ReadByte();
            }
            byte hasIndexSpecular = reader.ReadByte();
            if (hasIndexSpecular == 1)
            {
                cFile.tgiIndexSpecular = reader.ReadByte();
            }

            cFile.count3 = reader.ReadByte();
            for (int i = 0; i < cFile.count3; i++)
            {
                cFile.count3repeat.Add(reader.ReadByte());
            }

            cFile.count4 = reader.ReadByte();
            for (int i = 0; i < cFile.count4; i++)
            {
                cFile.count4repeat.Add(reader.ReadByte());
            }

            cFile.count5 = reader.ReadByte();
            for (int i = 0; i < cFile.count5; i++)
            {
                cFile.count5repeat.Add(reader.ReadByte());
            }

            byte len = reader.ReadByte();
            cFile.unkString = MadScience.StreamHelpers.ReadStringUTF16(casFile, false, (uint)len);

            cFile.count6 = reader.ReadByte();
            for (int i = 0; i < cFile.count6; i++)
            {
                MadScience.Wrappers.ResourceKey tgi = new MadScience.Wrappers.ResourceKey(casFile, (int)MadScience.Wrappers.ResourceKeyOrder.IGT);
                cFile.tgi64list.Add(tgi);
            }

            reader.Close();
            return this.cFile;
        }

        public void parseRawXML(int index)
        {
            index--;

            int level = 0;
            string curPattern = "";

            MemoryStream mem = new MemoryStream(Encoding.ASCII.GetBytes((string)cFile.xmlChunkRaw[index]));
            XmlTextReader xtr = new XmlTextReader(mem);

            xmlChunkDetails xcd = new xmlChunkDetails();
            for (int i = 0; i < 4; i++)
            {
				xcd.pattern[i] = new Patterns.patternDetails();
            }

            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element)
                {
                    switch (xtr.Name)
                    {
                        case "complate":
                            level++;
                            xtr.MoveToAttribute(0);
                            xcd.name = xtr.Value;
                            xtr.MoveToAttribute(1);
                            xcd.reskey = xtr.Value;
                            break;
                        case "value":
                            if (level == 1)
                            {
                                // Normal complate stuff
                                xtr.MoveToNextAttribute();
                                //Console.WriteLine(xtr.Value);
                                switch (xtr.Value)
                                {
                                    case "assetRoot":
                                        xtr.MoveToNextAttribute();
                                        xcd.assetRoot = xtr.Value;
                                        break;
                                    case "IsHat":
                                        xtr.MoveToNextAttribute();
                                        xcd.IsHat = xtr.Value;
                                        break;
                                    case "DrawsOnFace":
                                        xtr.MoveToNextAttribute();
                                        xcd.DrawsOnFace = xtr.Value;
                                        break;
                                    case "DrawsOnScalp":
                                        xtr.MoveToNextAttribute();
                                        xcd.DrawsOnScalp = xtr.Value;
                                        break;
                                    case "Control Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.ControlMap = xtr.Value;
                                        break;
                                    case "Diffuse Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.DiffuseMap = xtr.Value;
                                        break;
                                    case "Overlay":
                                        xtr.MoveToNextAttribute();
                                        xcd.Overlay = xtr.Value;
                                        break;
                                    case "Mask":
                                        xtr.MoveToNextAttribute();
                                        xcd.Mask = xtr.Value;
                                        break;
                                    case "MaskHeight":
                                        xtr.MoveToNextAttribute();
                                        xcd.MaskHeight = xtr.Value;
                                        break;
                                    case "MaskWidth":
                                        xtr.MoveToNextAttribute();
                                        xcd.MaskWidth = xtr.Value;
                                        break;
                                    case "Multiplier":
                                        xtr.MoveToNextAttribute();
                                        xcd.Multiplier = xtr.Value;
                                        break;

                                    case "Stencil A":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.A.key = xtr.Value;
                                        break;
                                    case "Stencil A Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.A.Tiling = xtr.Value;
                                        break;
                                    case "Stencil A Rotation":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.A.Rotation = xtr.Value;
                                        break;
                                    case "Stencil A Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.A.Enabled = xtr.Value;
                                        break;

                                    case "Stencil B":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.B.key = xtr.Value;
                                        break;
                                    case "Stencil B Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.B.Tiling = xtr.Value;
                                        break;
                                    case "Stencil B Rotation":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.B.Rotation = xtr.Value;
                                        break;
                                    case "Stencil B Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.B.Enabled = xtr.Value;
                                        break;

                                    case "Stencil C":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.C.key = xtr.Value;
                                        break;
                                    case "Stencil C Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.C.Tiling = xtr.Value;
                                        break;
                                    case "Stencil C Rotation":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.C.Rotation = xtr.Value;
                                        break;
                                    case "Stencil C Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.C.Enabled = xtr.Value;
                                        break;

                                    case "Stencil D":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.D.key = xtr.Value;
                                        break;
                                    case "Stencil D Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.D.Tiling = xtr.Value;
                                        break;
                                    case "Stencil D Rotation":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.D.Rotation = xtr.Value;
                                        break;
                                    case "Stencil D Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.D.Enabled = xtr.Value;
                                        break;

                                    case "Stencil E":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.E.key = xtr.Value;
                                        break;
                                    case "Stencil E Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.E.Tiling = xtr.Value;
                                        break;
                                    case "Stencil E Rotation":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.E.Rotation = xtr.Value;
                                        break;
                                    case "Stencil E Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.E.Enabled = xtr.Value;
                                        break;

                                    case "Stencil F":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.F.key = xtr.Value;
                                        break;
                                    case "Stencil F Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.F.Tiling = xtr.Value;
                                        break;
                                    case "Stencil F Rotation":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.F.Rotation = xtr.Value;
                                        break;
                                    case "Stencil F Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.stencil.F.Enabled = xtr.Value;
                                        break;

                                    case "Pattern A":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[0].nameHigh = xtr.Value;
                                        break;
                                    case "Pattern A Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[0].Enabled = xtr.Value;
                                        break;
                                    case "Pattern A Linked":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[0].Linked = xtr.Value;
                                        break;
                                    case "Pattern A Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[0].Tiling = xtr.Value;
                                        break;

                                    case "Pattern B":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[1].nameHigh = xtr.Value;
                                        break;
                                    case "Pattern B Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[1].Enabled = xtr.Value;
                                        break;
                                    case "Pattern B Linked":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[1].Linked = xtr.Value;
                                        break;
                                    case "Pattern B Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[1].Tiling = xtr.Value;
                                        break;

                                    case "Pattern C":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[2].nameHigh = xtr.Value;
                                        break;
                                    case "Pattern C Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[2].Enabled = xtr.Value;
                                        break;
                                    case "Pattern C Linked":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[2].Linked = xtr.Value;
                                        break;
                                    case "Pattern C Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[2].Tiling = xtr.Value;
                                        break;

                                    case "Pattern D":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[3].nameHigh = xtr.Value;
                                        break;
                                    case "Pattern D Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[3].Enabled = xtr.Value;
                                        break;
                                    case "Pattern D Linked":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[3].Linked = xtr.Value;
                                        break;
                                    case "Pattern D Tiling":
                                        xtr.MoveToNextAttribute();
                                        xcd.pattern[3].Tiling = xtr.Value;
                                        break;


                                    case "IsNaked":
                                        xtr.MoveToNextAttribute();
                                        xcd.IsNaked = xtr.Value;
                                        break;
                                    case "IsNotNaked":
                                        xtr.MoveToNextAttribute();
                                        xcd.IsNotNaked = xtr.Value;
                                        break;
                                    case "Skin Specular":
                                        xtr.MoveToNextAttribute();
                                        xcd.SkinSpecular = xtr.Value;
                                        break;
                                    case "Skin Ambient":
                                        xtr.MoveToNextAttribute();
                                        xcd.SkinAmbient = xtr.Value;
                                        break;
                                    case "Clothing Specular":
                                        xtr.MoveToNextAttribute();
                                        xcd.ClothingSpecular = xtr.Value;
                                        break;
                                    case "Clothing Ambient":
                                        xtr.MoveToNextAttribute();
                                        xcd.ClothingAmbient = xtr.Value;
                                        break;
                                    case "Rotation":
                                        xtr.MoveToNextAttribute();
                                        xcd.Rotation = xtr.Value;
                                        break;

                                    case "Logo UpperLeft":
                                        xtr.MoveToNextAttribute();
                                        xcd.logo.upperLeft = xtr.Value;
                                        break;
                                    case "Logo LowerRight":
                                        xtr.MoveToNextAttribute();
                                        xcd.logo.lowerRight = xtr.Value;
                                        break;
                                    case "Logo Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.logo.enabled = xtr.Value;
                                        break;
                                    case "Logo":
                                        xtr.MoveToNextAttribute();
                                        xcd.logo.value = xtr.Value;
                                        break;

                                    case "Part Mask":
                                        xtr.MoveToNextAttribute();
                                        xcd.PartMask = xtr.Value;
                                        break;
                                    case "partType":
                                        xtr.MoveToNextAttribute();
                                        xcd.partType = xtr.Value;
                                        break;
                                    case "age":
                                        xtr.MoveToNextAttribute();
                                        xcd.age = xtr.Value;
                                        break;
                                    case "gender":
                                        xtr.MoveToNextAttribute();
                                        xcd.gender = xtr.Value;
                                        break;
                                    case "bodyType":
                                        xtr.MoveToNextAttribute();
                                        xcd.bodyType = xtr.Value;
                                        break;
                                    case "daeFileName":
                                        xtr.MoveToNextAttribute();
                                        xcd.daeFileName = xtr.Value;
                                        break;
                                    case "filename":
                                        xtr.MoveToNextAttribute();
                                        xcd.filename = xtr.Value;
                                        break;

                                    case "Root Color":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.RootColor = xtr.Value;
                                        break;
                                    case "Diffuse Color":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.DiffuseColor = xtr.Value;
                                        break;
                                    case "Highlight Color":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.HighlightColor = xtr.Value;
                                        break;
                                    case "Tip Color":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.TipColor = xtr.Value;
                                        break;
                                    case "Scalp Diffuse Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.ScalpDiffuseMap = xtr.Value;
                                        break;
                                    case "Scalp Specular Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.ScalpSpecularMap = xtr.Value;
                                        break;
                                    case "Scalp Control Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.ScalpControlMap = xtr.Value;
                                        break;
                                    case "Scalp AO":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.ScalpAO = xtr.Value;
                                        break;
                                    case "Face Diffuse Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.FaceDiffuseMap = xtr.Value;
                                        break;
                                    case "Face Specular Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.FaceSpecularMap = xtr.Value;
                                        break;
                                    case "Face Control Map":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.FaceControlMap = xtr.Value;
                                        break;
                                    case "Face AO":
                                        xtr.MoveToNextAttribute();
                                        xcd.hair.FaceAO = xtr.Value;
                                        break;

                                    case "Tint Color":
                                        xtr.MoveToNextAttribute();
                                        xcd.TintColor = xtr.Value;
                                        break;
                                    case "Tint Color A":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.A.color = xtr.Value;
                                        break;
                                    case "Tint Color B":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.B.color = xtr.Value;
                                        break;
                                    case "Tint Color C":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.C.color = xtr.Value;
                                        break;
                                    case "Tint Color D":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.D.color = xtr.Value;
                                        break;
                                    case "Tint Color A Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.A.enabled = xtr.Value;
                                        break;
                                    case "Tint Color B Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.B.enabled = xtr.Value;
                                        break;
                                    case "Tint Color C Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.C.enabled = xtr.Value;
                                        break;
                                    case "Tint Color D Enabled":
                                        xtr.MoveToNextAttribute();
                                        xcd.tint.D.enabled = xtr.Value;
                                        break;

                                    case "Face Overlay":
                                        xtr.MoveToNextAttribute();
                                        xcd.faceOverlay = xtr.Value;
                                        break;
                                    case "Face Specular":
                                        xtr.MoveToNextAttribute();
                                        xcd.faceSpecular = xtr.Value;
                                        break;
                                }
                            }
                            if (level == 2)
                            {
                                // Inside pattern
                                xtr.MoveToNextAttribute();
                                bool isLogo = false;

								Patterns.patternDetails pDetail = new Patterns.patternDetails();
                                logoDetails lDetail = new logoDetails();

                                switch (curPattern)
                                {
                                    case "Pattern A":
                                        pDetail = xcd.pattern[0];
                                        break;
                                    case "Pattern B":
                                        pDetail = xcd.pattern[1];
                                        break;
                                    case "Pattern C":
                                        pDetail = xcd.pattern[2];
                                        break;
                                    case "Pattern D":
                                        pDetail = xcd.pattern[3];
                                        break;
                                    case "Logo":
                                        lDetail = xcd.logo;
                                        isLogo = true;
                                        break;
                                }

                                //Console.WriteLine(xtr.Value);
                                switch (xtr.Value)
                                {
                                    case "assetRoot":
                                        xtr.MoveToNextAttribute();
                                        pDetail.assetRoot = xtr.Value;
                                        break;

                                    case "Color":
                                        xtr.MoveToNextAttribute();
                                        pDetail.Color = xtr.Value;
                                        break;
                                    case "Color 0":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ColorP[0] = xtr.Value;
                                        break;
                                    case "Color 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ColorP[1] = xtr.Value;
                                        break;
                                    case "Color 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ColorP[2] = xtr.Value;
                                        break;
                                    case "Color 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ColorP[3] = xtr.Value;
                                        break;
                                    case "Color 4":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ColorP[4] = xtr.Value;
                                        break;

                                    case "Channel 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.Channel[0] = xtr.Value;
                                        break;
                                    case "Channel 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.Channel[1] = xtr.Value;
                                        break;
                                    case "Channel 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.Channel[2] = xtr.Value;
                                        break;

                                    case "Channel 1 Enabled":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ChannelEnabled[0] = xtr.Value;
                                        break;
                                    case "Channel 2 Enabled":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ChannelEnabled[1] = xtr.Value;
                                        break;
                                    case "Channel 3 Enabled":
                                        xtr.MoveToNextAttribute();
                                        pDetail.ChannelEnabled[2] = xtr.Value;
                                        break;

                                    case "Background Image":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BackgroundImage = xtr.Value;
                                        break;

                                    case "H Bg":
                                        xtr.MoveToNextAttribute();
                                        pDetail.HBg = xtr.Value;
                                        break;
                                    case "H 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.H[0] = xtr.Value;
                                        break;
                                    case "H 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.H[1] = xtr.Value;
                                        break;
                                    case "H 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.H[2] = xtr.Value;
                                        break;

                                    case "S Bg":
                                        xtr.MoveToNextAttribute();
                                        pDetail.SBg = xtr.Value;
                                        break;
                                    case "S 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.S[0] = xtr.Value;
                                        break;
                                    case "S 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.S[1] = xtr.Value;
                                        break;
                                    case "S 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.S[2] = xtr.Value;
                                        break;

                                    case "V Bg":
                                        xtr.MoveToNextAttribute();
                                        pDetail.VBg = xtr.Value;
                                        break;
                                    case "V 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.V[0] = xtr.Value;
                                        break;
                                    case "V 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.V[1] = xtr.Value;
                                        break;
                                    case "V 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.V[2] = xtr.Value;
                                        break;

                                    case "Base H Bg":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseHBg = xtr.Value;
                                        break;
                                    case "Base H 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseH[0] = xtr.Value;
                                        break;
                                    case "Base H 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseH[1] = xtr.Value;
                                        break;
                                    case "Base H 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseH[2] = xtr.Value;
                                        break;

                                    case "Base S Bg":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseSBg = xtr.Value;
                                        break;
                                    case "Base S 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseS[0] = xtr.Value;
                                        break;
                                    case "Base S 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseS[1] = xtr.Value;
                                        break;
                                    case "Base S 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseS[2] = xtr.Value;
                                        break;

                                    case "Base V Bg":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseVBg = xtr.Value;
                                        break;
                                    case "Base V 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseV[0] = xtr.Value;
                                        break;
                                    case "Base V 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseV[1] = xtr.Value;
                                        break;
                                    case "Base V 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.BaseV[2] = xtr.Value;
                                        break;

                                    case "HSVShift Bg":
                                        xtr.MoveToNextAttribute();
                                        pDetail.HSVShiftBg = xtr.Value;
                                        break;
                                    case "HSVShift 1":
                                        xtr.MoveToNextAttribute();
                                        pDetail.HSVShift[0] = xtr.Value;
                                        break;
                                    case "HSVShift 2":
                                        xtr.MoveToNextAttribute();
                                        pDetail.HSVShift[1] = xtr.Value;
                                        break;
                                    case "HSVShift 3":
                                        xtr.MoveToNextAttribute();
                                        pDetail.HSVShift[2] = xtr.Value;
                                        break;

                                    case "rgbmask":
                                        xtr.MoveToNextAttribute();
                                        pDetail.rgbmask = xtr.Value;
                                        break;
                                    case "specmap":
                                        xtr.MoveToNextAttribute();
                                        pDetail.specmap = xtr.Value;
                                        break;
                                    case "filename":
                                        xtr.MoveToNextAttribute();
                                        if (isLogo) { lDetail.filename = xtr.Value; }
                                        else { pDetail.filename = xtr.Value; }
                                        break;

                                }
                            }
                            break;
                        case "pattern":
                            level++;
                            string a1 = "";
                            string a2 = "";
                            string a3 = "";

                            xtr.MoveToNextAttribute();
                            a1 = xtr.Value;
                            xtr.MoveToNextAttribute();
                            a2 = xtr.Value;
                            xtr.MoveToNextAttribute();
                            a3 = xtr.Value;
                            curPattern = a3;

                            switch (a3)
                            {
                                case "Pattern A":
                                    xcd.pattern[0].key = a2;
                                    xcd.pattern[0].name = a1;
                                    break;
                                case "Pattern B":
                                    xcd.pattern[1].key = a2;
                                    xcd.pattern[1].name = a1;
                                    break;
                                case "Pattern C":
                                    xcd.pattern[2].key = a2;
                                    xcd.pattern[2].name = a1;
                                    break;
                                case "Pattern D":
                                    xcd.pattern[3].key = a2;
                                    xcd.pattern[3].name = a1;
                                    break;
                                case "Logo":
                                    xcd.logo.key = a2;
                                    xcd.logo.name = a1;
                                    break;

                            }

                            break;
                    }
                }
                if (xtr.NodeType == XmlNodeType.EndElement)
                {
                    level--;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (xcd.pattern[i].name.StartsWith("solidColor") || xcd.pattern[i].name.StartsWith("Flat Color")  )
                {
                    xcd.pattern[i].type = "solidColor";
                }
                if (xcd.pattern[i].HSVShiftBg != "" || xcd.pattern[i].HSVShift[0] != null)
                {
                    xcd.pattern[i].type = "HSV";
                }
                if (xcd.pattern[i].ColorP[0] != null || xcd.pattern[i].ColorP[1] != null)
                {
                    xcd.pattern[i].type = "Coloured";
                }
                //Console.WriteLine("Pattern " + i + ": " + xcd.pattern[i].name + " - " + xcd.pattern[i].type);
            }

            cFile.xmlChunk.Add(xcd);

            //Console.WriteLine(Environment.NewLine);
            xtr.Close();
        }

    }

    public class casPart
    {
        public casPart()
        {
        }

        public uint version = 0;
        public uint offset = 0;
        public uint numParts = 0;
        public ArrayList xmlChunkRaw = new ArrayList();
        public ArrayList xmlChunk = new ArrayList();
        //public stencilList stencil = new stencilList();

        public string meshName = "";

        public float clothingOrder  = 0;
        public byte unk2 = 0;
        public uint clothingType = 0;

        public uint typeFlag = 0;
        public uint ageGenderFlag = 0;
		public ageGender ageGender = new ageGender();

        public uint clothingCategory = 0;

        public byte tgiIndexBodyPart1 = 0;
        public byte tgiIndexBodyPart2 = 0;
        public byte tgiIndexBlendInfoFat = 0;
        public byte tgiIndexBlendInfoFit = 0;
        public byte tgiIndexBlendInfoThin = 0;
        public byte tgiIndexBlendInfoSpecial = 0;

        public uint unk5 = 0;

        public byte tgiIndexVPXY = 0;

        public byte count2 = 0;
        public ArrayList count2repeat = new ArrayList();

        public byte tgiIndexDiffuse = 0;
        public byte tgiIndexSpecular = 0;

        public byte count3 = 0;
        public ArrayList count3repeat = new ArrayList();

        public byte count4 = 0;
        public ArrayList count4repeat = new ArrayList();

        public byte count5 = 0;
        public ArrayList count5repeat = new ArrayList();

        public string unkString = "";

        public byte count6 = 0;
        //public ArrayList tgi64list = new ArrayList();
        public List<MadScience.Wrappers.ResourceKey> tgi64list = new List<MadScience.Wrappers.ResourceKey>();
    }

    public class unkRepeat
    {

        public byte unkNum = 0;
        public uint unk2 = 0; // Flags?
        public byte unkRepeatInnerCount = 0;
        public ArrayList unkRepeatInnerLoop = new ArrayList();
    }

    public class intTriple
    {

        public uint one;
        public uint two;
        public uint three;
    }

    public class stencilDetails
    {

        public string key = "key:00B2D882:00000000:75F8F21E0F143CAC";
        public string Tiling = "1.0000,1.0000";
        public string Rotation = "0";
        public string Enabled = "False";

    }

    public class stencilList
    {

        public stencilDetails A = new stencilDetails();
        public stencilDetails B = new stencilDetails();
        public stencilDetails C = new stencilDetails();
        public stencilDetails D = new stencilDetails();
        public stencilDetails E = new stencilDetails();
        public stencilDetails F = new stencilDetails();
    }

	public class ageGender
	{
		public bool baby = false;
		public bool toddler = false;
		public bool child = false;
		public bool teen = false;
		public bool youngAdult = false;
		public bool adult = false;
		public bool elder = false;
		public bool male = false;
		public bool female = false;

	}
    
    public class logoDetails
    {

        public string upperLeft = "";
        public string lowerRight = "";
        public string enabled = "";
        public string value = "";
        public string filename = "";
        public string name = "";
        public string key = "";
    }

    public class hairDetails
    {
        public string RootColor = "";
        public string DiffuseColor = "";
        public string HighlightColor = "";
        public string TipColor = "";

        public string ScalpDiffuseMap = "";
        public string ScalpControlMap = "";
        public string ScalpSpecularMap = "";
        public string ScalpAO = "";

        public string FaceDiffuseMap = "";
        public string FaceControlMap = "";
        public string FaceSpecularMap = "";
        public string FaceAO = "";


    }

    public class tintDetail
    {
        public string color = "";
        public string enabled = "";
    }

    public class tintDetails
    {
        public tintDetail A = new tintDetail();
        public tintDetail B = new tintDetail();
        public tintDetail C = new tintDetail();
        public tintDetail D = new tintDetail();
    }

    public class xmlChunkDetails
    {
        public string name = "";
        public string reskey = "";
        public string assetRoot = "";
        public string Overlay = "";
        public string Mask = "";
        public string MaskHeight = "";
        public string MaskWidth = "";
        public string Multiplier = "";

        public bool hasCustomThumbnail = false;

        public Patterns.patternDetails[] pattern = new Patterns.patternDetails[4];
        //public stencilList stencil = new stencilList();
        // Index into the stencilPool list
        //public int[] stencilIndex = new int[6];
        //public bool[] stencilEnabled = new bool[6];

        public stencilList stencil = new stencilList();

        public string IsNaked = "";
        public string IsNotNaked = "";
        public string SkinSpecular = "";
        public string SkinAmbient = "";
        public string ClothingSpecular = "";
        public string ClothingAmbient = "";
        public string Rotation = "";
        
        // Hair stuff
        public hairDetails hair = new hairDetails();

        public logoDetails logo = new logoDetails();

        public tintDetails tint = new tintDetails();

        public string PartMask = "";
        public string partType = "";
        public string age = "";
        public string gender = "";
        public string bodyType = "";

        public string IsHat = "";
        public string DrawsOnFace = "";
        public string DrawsOnScalp = "";

        public string ControlMap = "";
        public string DiffuseMap = "";

        public string TintColor = "";

        public string daeFileName = "";
        public string filename = "";

        public string faceOverlay = "";
        public string faceSpecular = "";

    }
}
