﻿ALTER TABLE [dbo].[IncidentDetail]
    ADD CONSTRAINT [UK_IncidentDetail_Description] UNIQUE NONCLUSTERED ([Description] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];
