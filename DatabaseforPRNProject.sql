USE [PRN_ASS]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 7/18/2023 2:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[QuestionID] [int] NOT NULL,
	[ExamCode] [varchar](50) NULL,
	[Stt] [int] NOT NULL,
	[Answer] [nvarchar](max) NOT NULL,
	[Correct] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC,
	[Stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 7/18/2023 2:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[ExamCode] [varchar](50) NOT NULL,
	[ExamSubject] [varchar](50) NOT NULL,
	[Duration] [int] NOT NULL,
	[TotalQues] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ExamCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mark]    Script Date: 7/18/2023 2:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mark](
	[ExamCode] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Mark] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ExamCode] ASC,
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 7/18/2023 2:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[QuestionID] [int] IDENTITY(1,1) NOT NULL,
	[ExamCode] [varchar](50) NOT NULL,
	[QuestionDesc] [nvarchar](max) NOT NULL,
	[AnswerDesc] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC,
	[ExamCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 7/18/2023 2:32:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (1, N'EOS', 1, N'A. 2 types', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (1, N'EOS', 2, N'B. 4 types', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (1, N'EOS', 3, N'C. 3 types', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (1, N'EOS', 4, N'D. 5 types', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (2, N'EOS', 1, N'A. True', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (2, N'EOS', 2, N'B. False', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (3, N'EOS', 1, N'A. True', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (3, N'EOS', 2, N'B. False', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (4, N'EOS', 1, N'A. True', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (4, N'EOS', 2, N'B. False', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (5, N'EOS', 1, N'A. A, B and C', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (5, N'EOS', 2, N'B. B, D and A', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (5, N'EOS', 3, N'C. B, C and D', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (5, N'EOS', 4, N'D. A, C and D', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (6, N'EOS', 1, N'A. Follow a code of ethics.', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (6, N'EOS', 2, N'B. Perform all tasks required of you.', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (6, N'EOS', 3, N'C. Engage with the public.', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (6, N'EOS', 4, N'D. Follow ethics by design', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (7, N'EOS', 1, N'A. a slim fit', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (7, N'EOS', 2, N'B. an easy fit', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (7, N'EOS', 3, N'C. None of the others', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (7, N'EOS', 4, N'D. a button fly', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (7, N'EOS', 5, N'E. a zipper fly', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (7, N'EOS', 6, N'F. a relaxed fit', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (8, N'EOS', 1, N'A. SCADA system', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (8, N'EOS', 2, N'B. IBM PC', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (8, N'EOS', 3, N'C. TENEX PC', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (8, N'EOS', 4, N'D. BSD Unix', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (8, N'EOS', 5, N'E. Apple II', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (9, N'EOS', 1, N'A. Utilitarian is not the only approach people follow', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (9, N'EOS', 2, N'B. Killing 1 person is worse than killing 5', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (9, N'EOS', 3, N'C. There is only one way to make a decision by relying on utility', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (9, N'EOS', 4, N'D. Killing 1 person for saving five people is a good choice', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (10, N'EOS', 1, N'A. Patent', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (10, N'EOS', 2, N'B. Trademark', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (10, N'EOS', 3, N'C. Copyright', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (10, N'EOS', 4, N'D. Trade secret', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (11, N'EOS', 1, N'A. True', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (11, N'EOS', 2, N'B. False', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (12, N'EOS', 1, N'A. certain general conditions that are...equally to everyone''s advantage', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (12, N'EOS', 2, N'B. certain ideals toward which we should strive
C. A fair action', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (12, N'EOS', 3, N'C. A fair action', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (12, N'EOS', 4, N'D. an action respects the moral rights of everyone', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (12, N'EOS', 5, N'E. that provide the greatest balance of good over evil', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (13, N'EOS', 1, N'A. Bribery', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (13, N'EOS', 2, N'B. Providing False Information', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (13, N'EOS', 3, N'C. Whistle-blowing', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (13, N'EOS', 4, N'D. Provide too many options in the Job Interview', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (13, N'EOS', 5, N'E. Fraud', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (13, N'EOS', 6, N'F. Breach of Contract', 0)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (14, N'EOS', 1, N'A.Keep sessions short and focused.', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (14, N'EOS', 2, N'B.Keep sessions interactive.', 1)
GO
INSERT [dbo].[Answer] ([QuestionID], [ExamCode], [Stt], [Answer], [Correct]) VALUES (14, N'EOS', 3, N'C.Keep the content simple and direct.', 1)
GO
INSERT [dbo].[Exam] ([ExamCode], [ExamSubject], [Duration], [TotalQues]) VALUES (N'EOS', N'ITE', 5, 10)
GO
SET IDENTITY_INSERT [dbo].[Question] ON 
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (1, N'EOS', N'In his speech, Mikko Hypponen pointed out how many types of online attackers?', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (2, N'EOS', N'Freedom of Expression is not recognized as a fundamental human right in human rights declaration of 1948 by The United Nations.', N'(True or False)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (3, N'EOS', N'Sedition is a representation of freedom of expression and it is legal.', N'(True or False)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (4, N'EOS', N'Barry Schwartz convinced that the more choices people have, the more freedom they have, and the more freedom they have, the more welfare they have.', N'(True or False)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (5, N'EOS', N'Whistle blowing draws attention toward the act which poses threat to common interests such as .....', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (6, N'EOS', N'Which of the following are ways to participate in engineering activism? ', N'(Choose 2 answers)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (7, N'EOS', N'In his self-example, Barry Schwartz wanted to buy a new jean that is ....', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (8, N'EOS', N'In 1981, Elk Cloner was created by a fifteen-year old high school student, Richard Skrenta, holding responsible for the first large-scale computer virus outbreak in history. Which is the targeted system of Elk Cloner?', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (9, N'EOS', N'Which is implied by Dr. Sandel in two different cases?', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (10, N'EOS', N'Technique used in manufacturing a product is categorized into a ....', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (11, N'EOS', N'To become a junzi-a man or "superior man" - a gentleman or a sage. in Confucianism, kindness. sobriety, righteousness, wisdom and trustworthiness are given to human-being with one-self to self-improve.', N'(True or False)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (12, N'EOS', N'In justice approach. an ethical action is ....', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (13, N'EOS', N'Which of the following is NOT one of common issues that can create friction between employers and IT workers?', N'(Choose 1 answer)')
GO
INSERT [dbo].[Question] ([QuestionID], [ExamCode], [QuestionDesc], [AnswerDesc]) VALUES (14, N'EOS', N'What makes ethics training effective?', N'(Choose many answers)')
GO
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
INSERT [dbo].[Student] ([Username], [Password]) VALUES (N'thinh', N'1')
GO
INSERT [dbo].[Student] ([Username], [Password]) VALUES (N'ThinhTuan', N'12345')
GO
/****** Object:  Index [UQ__Question__0DC06F8D657FBB64]    Script Date: 7/18/2023 2:32:21 PM ******/
ALTER TABLE [dbo].[Question] ADD UNIQUE NONCLUSTERED 
(
	[QuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD FOREIGN KEY([ExamCode])
REFERENCES [dbo].[Exam] ([ExamCode])
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Question] ([QuestionID])
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD FOREIGN KEY([ExamCode])
REFERENCES [dbo].[Exam] ([ExamCode])
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD FOREIGN KEY([Username])
REFERENCES [dbo].[Student] ([Username])
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD FOREIGN KEY([ExamCode])
REFERENCES [dbo].[Exam] ([ExamCode])
GO
