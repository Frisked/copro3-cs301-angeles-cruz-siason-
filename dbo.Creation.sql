﻿CREATE TABLE [dbo].[Creation] (
    [player_id]     INT           IDENTITY (1, 1) NOT NULL,
    [nickname]      NVARCHAR (50) NULL,
    [AgeGroup]      NVARCHAR (50) NULL,
    [Height]        NVARCHAR (50) NULL,
    [BodyType]      NVARCHAR (50) NULL,
    [Gender]        NVARCHAR (50) NULL,
    [SkinTone]      NVARCHAR (50) NULL,
    [HairStyle]     NVARCHAR (50) NULL,
    [HairColor]     NVARCHAR (50) NULL,
    [Heterochromia] BIT           NULL,
    [EyeColor]      NVARCHAR (50) NULL,
    [Race]          NVARCHAR (50) NULL,
    [Class]         NVARCHAR (50) NULL,
    [HeadGear]      NVARCHAR (50) NULL,
    [UpperGarment]  NVARCHAR (50) NULL,
    [LowerGarment]  NVARCHAR (50) NULL,
    [Shoes]         NVARCHAR (50) NULL,
    [HeadAccessory] NVARCHAR (50) NULL,
    [BodyAccessory] NVARCHAR (50) NULL,
    [ArmAccessory]  NVARCHAR (50) NULL,
    [FishermanP]    INT           NULL,
    [BlacksmithP]   INT           NULL,
    [FarmerP]       INT           NULL,
    [LibrarianP]    INT           NULL,
    [CartographerP] INT           NULL,
    PRIMARY KEY CLUSTERED ([player_id] ASC)
);

