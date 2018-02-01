-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: twittclient
-- ------------------------------------------------------
-- Server version	5.7.20-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `mensajes`
--

DROP TABLE IF EXISTS `mensajes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mensajes` (
  `user_emisor` varchar(20) NOT NULL,
  `user_receptor` varchar(25) DEFAULT NULL,
  `fecha` datetime NOT NULL,
  `mensaje` varchar(250) DEFAULT NULL,
  `num_rets` int(11) DEFAULT NULL,
  `num_favs` int(11) DEFAULT NULL,
  PRIMARY KEY (`user_emisor`,`fecha`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mensajes`
--

LOCK TABLES `mensajes` WRITE;
/*!40000 ALTER TABLE `mensajes` DISABLE KEYS */;
INSERT INTO `mensajes` VALUES ('@bea','','2001-01-01 00:00:00','0',0,0),('@javier','','2018-01-22 00:01:02','HOLA MUNDO!!!',5,5),('@miguel','','2018-01-29 11:58:25','System.Windows.Forms.RichTextBox, Text: soy miguel',0,0),('@miguel','@bea','2018-12-01 00:01:03','Yo solo soy una chica!',5,5),('@miguel','@bea','2018-12-01 00:01:04','NSE',5,5);
/*!40000 ALTER TABLE `mensajes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seguimiento`
--

DROP TABLE IF EXISTS `seguimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `seguimiento` (
  `user_sigue` varchar(45) NOT NULL,
  `user_seguido` varchar(45) NOT NULL,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`,`user_sigue`,`user_seguido`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seguimiento`
--

LOCK TABLES `seguimiento` WRITE;
/*!40000 ALTER TABLE `seguimiento` DISABLE KEYS */;
INSERT INTO `seguimiento` VALUES ('@bea','@javier',1),('@miguel','@bea',2),('@bea','@miguel',3);
/*!40000 ALTER TABLE `seguimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `mail` varchar(50) NOT NULL,
  `contrasena` varchar(45) NOT NULL,
  `estado` varchar(100) DEFAULT NULL,
  `nombre` varchar(45) NOT NULL,
  `usuario_twitter` varchar(45) NOT NULL,
  `seguidores` int(11) DEFAULT NULL,
  `siguiendo` int(11) DEFAULT NULL,
  `foto` blob,
  `favs` int(11) DEFAULT NULL,
  PRIMARY KEY (`usuario_twitter`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('bea@mail.com','1234','Hola, amigos, soy bea','bea','@bea',NULL,NULL,NULL,NULL),('admin@mail.com','1234','Hola, amigos','javier','@javier',NULL,NULL,NULL,NULL),('jose@mail.com','1234','Hola, amigos , soy jose','jose','@jose',NULL,NULL,NULL,NULL),('miguel@mail.com','1234','Hola, amigos, soy miguel','miguel','@miguel',NULL,NULL,'ÿ\Øÿ\à\0JFIF\0\0\0\0\0\0ÿ\Û\0„\0	\Z\Z( %\Z!1!%)+...383,7(-.+\n\n\n\r-% %/--20-----//-/-------/----------+-----------------ÿÀ\0\0\í\0\Õ\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÿ\Ä\0>\0\0\0\0\0!1AQaq\"‘¡2±Á\ÑðBR\á#br‚ñ’¢$3C²4ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÿ\Ä\0.\0\0\0\0\0\0\0!1A\"Qa#2Bq±Á\ÑðR‘ÿ\Ú\0\0\0?\0\î(B\0„!\0Bm»@08W\â -c\Ó3\Ì	\ä.|_eû\\j\Ñ}J\ÐKr»º\0i¼%_úŠ\Æ†\ÃQž£œ±°=\\–¿\r6¤Ù¼º‘<€<¬	66±¢Šc\'»öw\æTf\ál\n—³IÃ°Z\\\Ó\àO\ì­\éºBde©	”x¶Œ×„ ”Ÿ\Ú°\\\â\ÜÁ´›cx\ÍÌÀpKº\èÔµš®§c\Ä0bö\Õ\Zf¤ðhŸ‚Œ\ÎÐ°Ÿq\ã¨\\\ÛÚš,œ™ª8Xµ‘›þZø	U\ÌüD¤M\ÝZ÷†º0|»Š,ÿ\0í“µ\é?óGU8<\n\ç[µŒ¬!•©\Ö#V\Ø>?¡\×=B`¡c„´\å?\Êe§\Âly-\ÇÊ’ýÿ\0ð&t}¿\È\Í+\ÇTR[%\\VÙ©M¤o\0ý\Ý/bv\Æv<ŠõYRwÝ¦:h8S\åEú2¼wòtÆ¸ƒ+\Õ\Ï\n6\ÕZŸ\ê0ÕŸÔ‹\ÒH0Ç‚2\ØÙ¼žö¥t%Jz´L–<!\Ó „!\0B\0„!\0B\0„!\0Bÿ\0¨Úü0\áN©óu1òõIÝ•\Çd{CH÷ZñÕ¤j8\\Jbÿ\0¨x©‹eÄ²˜aþ§¸:9@ý\É²´\ãÅ¯< ü’¬_K)¥\ä\Ò>€\Øq†»ƒ^Àr\È\î¸@°á­¹&&m\Ú÷¼h¸NÊ¬\êx¹2°‰¾ø]!¡¡†£ž³\Ä\ÄÀû·Š‰\Ý5$‘Už<Wc\Û\Û–`»­‡U\ÍñøŸl\ç4Gv\"Ð›\ï\ÔO\îTý¤üBmZ‡ \î¶7\Þ\Éjž\Ùe\ÌA.’D\Ü‘÷\ÅbU[9r—\èj§\\#‰öY\Õ\Âfq\ÜÆ€I\Z€\é\Ð\ë&—Ž¡Qö‚¤÷@‡3GZ\\8;~a¨<-À¦¡¶R›i²\0±q\Ð\î\éòTx—Q{Ä¸L¹\Ä\È\ÐXk¾	·$\ê\ä\Ó\íÚ“^\Ä\ïjö¼]ch0|\ã\Ít>\Ãö¶«\ê{*\Î\Ìr\Ëjž\ëž\ê1¼\Þ\Éi¸*w—†€Nº\ê\Ø\ÒtQAk\Þ\ÇNY\0‹X\ÞIö(\Ù\ÂXE\Â[§tœð\Ù\ï8\Ã\ÄoŽ\ï\É*\íŠ.¦\ì\à˜:ƒik \Â\ÜV¾\ÇmOo…ü\Ô\Ü\ÆRGˆ#\â®\ë´Vc‡38\äF\å\Ì\î¹c,M5¨•øV\Ãþª¬\Þ(\å\Ï@ðZ\Òw‘.ŽG|.¨\á¶=\ÐsŠaŽ;ˆ\ÌHñ‚~]j^Á3›\ï°Bš$„ B\0„ B\0„ k\Ä\Ökž\ã\rh.\'€JØ‘¿¶¿°À\Z`÷±\Ù\Û\\°\\ÿ\0ø‚?¹x\Ïbµ\áÀûIµ#S\áb÷¼\ê$4x44x/;2ø\Ä\Z”3=bT<3sM\æÿ\0|SV\Ä\ÃÅš\Ì\Û\ïp>¥\"\é%Š\è‡))½\î¦\ãW#ˆÔÀn“\ê¨vö\Û5_2H\ÒGBy•\Û<c\ÛA¬‰/$ºû…¾;¹$\n\Ï.9N‚ý]cÇŠ’\ä\ÆyV´ø£\Ç\Õ.6?aLÀ\Ð$\â|>jk4#»ÀŸÈ©‹¸-hdpT´Dš]²ýÝœ¨Hw´†\ÐdrQ±\Ø2\Þ\èª\0\Ó)\×\ÏT\ÑKNŽ>öA\'Á!\Ò\Ä÷\å\×\ïs\ã\É&¹J[¿WFK³,K\È{6\Ì@ƒ\Î.¨@·Œ\ïEJ\Í$‘¼™L\Ï32_$\â]\Zÿ\06±¤ú”\Í\ÛQ³°û\èŸö\"j¹‡|‘\Â/¢\ãX\nŽe@GC\ÑtŽ\Ëm\"kDO¯ ôQùU\î²\ßNS°5\0©ˆ§¿ºc\Â$rýÓ¨I‘¤)\äo§\ÎS¸Nñ^Ö‰|…ûFBAB\0„ B\0„ B\0üv\Æb)Ó›R¤O÷Tuý\ß2»rá¿‹\Øl\Ø\çH7§LŽ§\á\è±7ˆm1\ä\ÚüŽk‚%6l\ZÀØ¼‹KÔ©\0ü­\ã\0N¼\É\Üf\Z“iS—\0`L€aI{Y…ôC\r½£ÁR}\'we\î“x‰6	llŸôô…\åï»¿•»„\æe0¨]Q Ù¢Gž¶Vuj±òVkr«ôn\Ê\ágó9¶\Ï\ËMôªÖ¥\íif2\Ì\ÙsÆ­\Ì.5[6>Ö¨æ¶˜!À\ëš)‚Gx^\äh\Õ<³`aÌ—So°¶U*C-6€8]P\ïÞ¢‰W‰\Å\ì\Ú\Ã3„—³À@Hxü3(¶¥:”\ßí³ƒN¦a“\Ù\ß0-‹™‹Žiµ\Ûp“ XU\ÆS©Ý¨À\á¼¬W\Î\ÐÛ”-I\'\èH«\ìòSÉŸ\Úw½¤\ÆM{™ Nš\Îõ\î›œûJf¯±p\Æ\í“Œ/pX*t\ã/™7Nv¬[\ÛEc6fR¼\ë5y\Ù\ÊÁ•\Ú\rÁ\"~œ\Õv\ÐÄ†¸Ú¢\Ïb‚\çœ\Ã\Ñ.Z\ã\ØÄ£dNõ\Ù\'ÿ\0\Ü\Þ\ÂOKšv\ä\Ôk§Cdi\êKñVCy?¾B$\à„!\0B\0„!\0B\0„!\0\nƒ´ý’\Ãcš\ßl\É\r{Zð¢F À±•~¼+ÆSi\ê>|\íŸg°˜LSpô}¤µ¡\Õ^ú“˜º\á 6Ú˜¼ªÊ®uGƒ\Üh¸\Ý\'\ïrc\í\ÍÝ­_=\Ú\ìŽ\í”tªw41Žv…Ä¸øý…\ë:Ô¯Ù¦+\Ö÷¼U\Æ\ÍÃŸx\è¢\ì\Üªò\ï\Ê\n±Ç¼¸Š½\ãnœO‚d\åü\"kŽ}LZ½J®4\éi¼\îñ*~³ô\Å\êÇ¬)fžQ\âw“¼•WŒ\Ú\äXz¤òœú‡H{Œ#\ÜûeÀÀ\ÑoPq».“´hˆ±ôT•6\Ëÿ\0R)mgq•\ê¦\ÅÞƒ¾§\Ö\Z6žô¯r\Þ#w_ª€kÑ‡Ç‡Y\ÑuS´p›¤\ãvœ‰Ü	¿R\'¶¯\âƒè©ª\Ü\ÄOO5/c\×öMqˆ0|\ã\â°²¿)L}–Â¹¸\Ú[Ÿ\ÚVh\ÈZ\ÒO¾;\Ý\Ó\ÝÍ¯¹µ\è]Q}\Ë\ìt/\Ã/\ãMBY¦fhÃ·\Ç×‚\ê\Ê=3\ZZ\Ð\Ð\ßt4\0@,¤-\Âz&²|Þ‚…³\0„!\0B\0„!\0B\0„!\0Â½^\È(Ž¤ð=\êmkº\ætz\Ú\n¹[}—CüY\0:›·Œ³\Ó1\\Ë´—\Ó^\ÏR‡Ý¿©Ôƒ\Ê?BkZ(\Ð\ç<\Ê6,”\ÍwûÏ¸\Í\Ýç¯’‰¶\Þ_Rù\Ü\×\ÒTž\Ñ\âr40pÓ\Ñc\Åÿ\0o\è5´›þ¥f?\ZjT\0†b²Î«\ßw\È<7ø¬66ÎŽûýó\è\n¼4H\Én\Ë1pšª\×\Î~\Íô[M­I‘ý!V\ãv}\Ì\Òh\'xO˜[Z\nÁØŽ:)“’~\ÙS„\Â±\Û=Ô‰-%\Ìõù©XWŠ¬4\ÜEÅ=\ÊÆ¥@Uv{\Z­s}\×pxùª\ã.k²IWøoW§\ì]¦)“\ï–;­\Ï\É8vQ\Äcð¡«qýµ\\Ú´\áÿ\0\Ôö¿þ	Ÿ°d¥\0L\Z¤òþKø-n\áž<T¿ßƒ¾…\êð/UG,„ B\0„ B\0„ B\0…z±©¢\0\äÿ\0‰•œùŽ>\Ð.m´«K¨;ù\Ù?\î¤vý\Í\ïEòº$i&\Ç\Âþ‹”mJ…¤ƒ¹\Ò9as|W\Ëw\îÎ­V‹Ýš\Ìø§?u0c©°ù­u›\í±cô²\\yÅ€óø-›¨4ŸT\ìq>\r´y\Êó`	5Ÿü\Ío•\Ïÿ\0Krx\Ûû,5¤¢¾\ïKf˜*C1M¸\'U	£1\ä\ãL_\Ñ-bõ‘ñG†ŠJ–¹S\\&\Åh4Á¶\îk\Ø\á\ë\ä‘£\ïºV¼c3\Ó<Gxug\Íe‰§‚(:AÁ7óB\ßi¦F\ÇT\ÍQ£ƒ[\æDý—\á-V¦jeŸBW?\ÄT>\Ù\Í\Ê<˜\Ôÿ\0øU†,\ÆÓ¨f\ìp˜A´x-j†h‰>Q—\êwT/\ZWª³–B\0„!\0B\0„!\0B\0„!\0]pKH1e±cR Î›×ŒGø‹I£+i¾‹›“6ê¹¾\ÒÀ44’\á<\Í\ÏN©\Ä>®2¶`\àZ\ì¹`Z˜÷E´´\æR®Ó¤ÚŽ´4\r\Â\åsky,Go†\×\Ùd\â\Ãh:—\é.#£ŒüIòVÝžÿ\0\Â\îow RR 3Y®ž?z+í“‡u&¹¤\È.–˜@G(õN³8±U&¤¿-$bñ•2\î\0”—³ûKS\Û\ë±\Æ2ð’ §-§C=7¶uis=#\í\ZØ¾`<e{Dc(½3\åY8J<N¥Y\×	/´m\â©c†\ë\Õ4×©\Ý\×E\Îö°þ3\çŠ<x&û5\æ\ÎQŠÁ\Ïf\â}£Zy,\Ø`¿§\ÉWvtDNý¬MP\ÒwÉ¨k¶\Å\ìf\Ü+\Z\êŽ0™\êE¾IÇ°\îÿ\0¸s\æ2Gê±”Q¢©™“q¼iß³,\rlOz\Þ%M\äËŒt\Üc«Ù„®Ö›\Ü)	W³ø\êya\î Í¸z&:š}\×J³Ç½Y­\éÉ¶§	Ð¼•\ê¤H!@„\0!@„\0!@Æ ±^\ÊÁµ\ÚIhp$j&\ãÁxÀãŸˆ[8Ñ¨CƒjIs \ÎmMô½Ì¤\\{À\è§1ó_Dö›F½Qª\è\Z\áy\\o\'\í.\Â\ÖS%\Îa3˜e\à8\rð7®}‰Tñ|\ßÄŽ?fœ6¹g(;§\ä•ûWŽu*\Ô\ËA†´\Ët4ô7N¸p\r8w\ßT•\Û9s\Ú@./0\0s6$@\Ö~©^3\Û1›¿T5ðø±Q\í6>‡‡PUEM–ÁS\Ú\ï\Ô\ïQ¶mSD¸:Cs\0\àA\ãi×²³\Ä\âl¨\â\àúô{b›öŒkU²_\Çl\ÑUÙ¦õcZ¼¬i¹nI\å±Vt\Íø*`44n€¬1X6†’Eø\ßUŽ\Ê\Ã\æp$³ngö[ûVü€\0uI”¶i!F\"ý3\å²i\Øx¡5\äµ\ÓgN¼•p„­ù¦]œr\ÙÀ8Ž–^y)5W\Üx\Ù³\Í0a6“›v»\Ò\Ï\Æ:›ƒIvSv¸\åmG$\Ä\Üh€/º\ç\æ¹•r\Ô\Í\ÙZ—À\áCm¼k\Þðú)lÛƒ{|ŠL¥‰’Ã¹˜R[‹k}\çyýS£\æ\Ý¹\ËÅƒø(\ã\é»G	á¢’\nD\Ã\â\Ú\íC¢½Ù»HL8 üŠ\èxÿ\0ýo\'\Ñ%¾+h¿BÂ›ÁY®’zFB B\0±|\îEG€	&\0J[w´.\0†Àn–\Ôø\îH¾øÔ»U2±\â\'\íM³\ì	\ïž-\â>!mÍ²\Ç;8`cÁ$8Y\×ýN™*‹nm÷8˜6\Þ>ù¥\ê»X‘\Þ2\Ý\ÜW1þ-\Ý\Ë\×\Ø\ë\ÕD*\ï\ä½\ÄöÎ™\ÇY$\îñU5±\Î\Íi•)=\àeº‘¼¬\0 \íò\"g\á\ê›\Z£Ct{À;=8Ÿ_©P¶“}“\ÛX\ÌS’?+\\\07\Ä_—E³\Ùî“¦\åy‹h6\"d\Èñ•?u\Ù\Ùä–¬;eF“ð\Þ\ß\Ú5\Ï.\rfW®¹‘\ËÞ”µ³±®{2’37Š›·;:ú.uF€\ês2#0øªfÛº/\Ä>­Z‹‡ONd§(Y¯¢P¨\â\æ²;\ÏpkG\0y”ÉŠ\ì½L>A‰¨\Æ\Ôy\0R¦\ìõ Ø¸î·T»†¢\Öe««Ád\È#H\á\ÆBsØ¸G{z\Ï5R2—\\†Áƒ<\Ò\î—£)\ÙH™G•\í`\0†6do\ç\n‡´ƒ\Ú>\á¢foº\ãÌ#O‚M\Ä\Ô.¨÷\ÊgÁKOr\Ò\é%˜@\ÃÓƒ\Ñ_\àq@4f\Æ`\ß5MY‚s;g¼‚&2\ÇCôº}«’1_]¢CZû{\Æ9\Øf²¸k¦˜p\ê ª‚sŽ\íƒ\0¦ýyÊ°\Ù5{¹N†W*\ÅÖ”£Ellyû\Ý\Òö^`ö\Û\Ú\ìŽ2-\0\é‹F\ÕÁÁf¼\'ˆóU5\\\×A& \ÏI‰òðM…pš<oŠ{]‘z#Œ°\Í\Ô\Ì.\Òk®$\Æ\è ß‘\\\Ü‰\Ö\Ü\è°\'tþ\ê\Çfc\\\î\ë¬\à—?¦g\ÓövÐƒ-\Í\Ó_DÏ€\Ú-¨9ð\ß\ä¹^\ÎÄG{œ‹ñ\àœ¶&5pipŽ\ë¬\'–‘~;Ä¾UËƒd^U9!\Å]\'H½Žô.\â\ì\åŽt/J \Û[T‰¦\Û\Ì\ï¢M\×F¨òc+­\ÎXˆ¡\Û:µ¤e¤.u·ö™\0dŸ!;”ý£ŽöŽ-•œ4q\ç\çè”»@ò[QÃù²\ãE\Ê\ë9L\í\ÕR®8Šª•\æ¡mBb\à\Ó\Ì-Œ3š\èZ#N±\nY‡f$|´º\ÏÌ¯\Ä9®\Ðò\"3º\àŽŠ\îXzÖš\Zü‘k:_P‚û:\Ñ2\à°\Â2\î¦Oy£Ïš\ÕB±.oò\è´\Ù8\Èp;Œ[‰N4\ê\æ†£†Ÿ¼$½G3]Z:&}ºÀmÑ—M\ÓôR\ßÞ¡‘\Ü-k9\Ü:^~ª•»\Zžw; ƒ­„\\ðV\ãa``Nø\åó+Uf¸hr\æ1\é\è•	\Ê=#\ÉA?esv}*ud4D\ã\ÍO.\rkCl\× [+u¢Êƒ\Ú}£\Ý„\Ö\ßEhV\rq$\ãÓšÓ”¤ñžF)z5\í\\HcOÿ\0t«¨&uSvž\Óö¶´\Âòª\r7f#qWMy~\Å\Îx\×Ø˜•\Ð}\Ó>ª—‡§\rm÷¸u\î²\Ð\è?¨Z\Þ\nf™Ì¹³\Ä\\ú‰Ë£qE†\ËAuñÜ¥Ð©¡<y]²Ÿr\Ò?\È\á\á*h¦=\Òm¨ñ¸õQØ–´Æ¦Yc\Î`²Ž‰k2€b\"OI*ó\nd:™,~ü®ß¨s@µû\ß\Z=ñ<³¥¦Še\ÎpýQM7ñV\rª3½\ÂFÿ\0+£\ÑM“¼üNž¼\Ã\Îqq¡¾*¹v-X=¨\×6$\î’ü\Õþ\Zn¿X\Ò>‰\Î\ç`b\ÛÀ´„Á„\Å\"üWV—£~\×ge\Øx\ÃR˜.\Ôo\Ü\áÇ­®„•Ù½¼\ê,-\080wþz¯Uõyµ¨%\'\ÙÈ³ÄŸ7\Åt?\ãñ7;€õ\\\Ënm=I·…\Ï$\å\Ú\ìfVeJ\æ¸\æ’s¼O\é…/›>vñøE~\ryLÑ†\Í\ï\Z‚F\ëaóUx¶S¼¸\Ï;Â´¥T<@?¨.=ß¢¬©‡Œ\ÍF\àuD¨{g@£\Âw*\á˜N·õ\Êf,6$n›znQ\ëSƒ\ÞŒ\ÒTJ\ã‡\×üÊ·9=è‹‰¦\às\rF¿5¤\Õ3*}[u\ÐðQö•!\Ã\Ý#^\è½2y\Ç;Cf\èS‹ð\ål\Ç\áÃª¢.IŽ(ì»®Á¼°?ee²hf\Ì\â\'ÞŽ§O‚\ç\Ù7\ÊEp_J*\Þ\Ñ?·E:\\’A\'yƒ§NJ\é´2ºþ\\:­4ð\×s¢\ÙI¾ï²™#\ìòQ*Ž:£¤­µ•£‰qNŠñ¸iq\ë\Ã\ÍW\ãpý\ç¶¿\Û\Î!d[\èË‹H¡¡9£~¡KÄ¶L\î\"GMè©†¼·uÁ\ç÷¹K¢EF›e{DÆ²±\æŸ)|‰Œ_¦cƒ÷\É\Îw\np\Z6þò3\àTZ\ÐX‘#™˜õVT\Ä¯>ú‰¾\Æ\Åthª\Â×¶£40HÝ®\ï5mN°.#ò›´s\ÔýóQa%†û¥¦òŠ€7n\æ‘,‘µ\ÑgD€z¿Œ¥>\ÓR!\ä\ÍËŒÿ\0vŸ|“#`yA¿qðPv\í!Q£s\ÛûÆ¿}W”>X¶%4\å¨\á¸d/\ÙXµ\É™\Í\' &}J¨\Å8û\Çyq§\Ç\ÍY\ìg—\ÓsI¸\"\'ù‚²k\"˜¨?«	ô\0Å¢$õ*u:„I\èBªq!\Ñ\Ç_‚—J -p\ÑÀBšq\Z‹¿ošúqŠM˜ðYsn¤’Ç‡£ÿ\0hq`\Õwv÷ô°û\æ“v\æ%\Ùa¾Quu\ÚhZw™\ßª¡Ùž ›ðóù!½±\Íý\Ì\Ó‚B\í*5\ZI\ËM\âÀƒ©ò¬N<>\àv\ç[üÔŒe< eü¦#‘U\ìi/¦\Û@1þT§û™\èÙµ0®-H\è~!/W¬\êd\0:h­N,$n\é\Ì}u™J§¼5\ß?~iðn?B\ä¹z}”\Ï\Å5ÿ\0+M\Z¤»)ñ\Íc¶¶[©¸;®÷\\.P¢`j™$ƒÝ·;nU$œu»%ÏŒ‡=ˆ\Â\Ò8µ®\Íò“gš;ÀÆ‚\Ü=ïª§\Ù\Ä;¼\ßÍõ§\èTü#E*Ÿ\ÊEùó\\‹þ­GJ+£\Ê\Ìþ6^!\Äsµ‡¡ZiHs™ÅŽ‹\ï²Ý‰’\çg7¼Ã»Q\Ú¼\çmQ¬‰2É²!ý‚^‹\n¤>8\Ú\ÜTN7xð\'¡‡7\ä¦a\ë\ëxpûú,]JYSŽZò\Ë)¸³ÁY´œHü¤kkøè¤²\Ì\ÍE\ã‹N¡Ms5Z\àGC\Ë\Ün)9Í€\à34Ž$\ß\Âc\ÍX\ì\ì^›L{CL[8\î[s\n\Ð\Ó\ãù´\ë ß¡•O3)\Ö\È\'¬ÁðŸŠ•´ña¤À¸ñ± Ÿ,Ò•&\ä\Ö¸kÑ©î‡¶l#•§‚ð.¤\Û[ý•YS\×X™½¯ã¸­­®\Ü\Í.0H¾\é\Ý<Š\ßá´9\"\×36ºdyýø*m«Xä™ˆÓ”\ÙZ`†Gfl\älII\Ð8ŽªsI\ÄfZ\íHxi\Ý.\á\Éf?L·\àòO¬\ë¿=0f\í7ú¬¶mR\r·Àð\ÇÁ2\â;6\Ç8û(§2.\æj\í\ÖT\Ù\Ï\Ã\í —i–H·Q\â«SŒ–\"tŸ$\Ë\\iivºI? £\ì\ç’\ãx\äou\å&Œ™Ý qñ1`£V¦[\ßn²g\Ò\Þ	i,Á\ÍüŒ8p\"\â(›3h5\Í9¬F²P¦”$Ÿ£z‡W™6ló\Ü>ª7=\ãr.\'Iú©˜ªð õû*~ü™·;U7t\ÒEKñ‚]:­ô©¿Q‚‡´W\0 \î\ÜÊ÷ \ØIžF\Ê\Çº5¥v\ÖÁ™\ÆÊ¥\Ô\Ëtû	¿\ZdA…G^ˆ¼jŸM­®\Ì\Î\ÑO¾\ÇR}\Ú\è-\Ð\å$c»D»M\Ð\ç¶o$x\è­1¯†\ëp[ÿ\0Ðº\\‚\çq$\È\Þf}UµG¦sü™ñ’6C4™7pª\Ï’öúñVgKƒ¸6O\ßÝ•\'fœz\'ºIÿ\0mþ\n\Ï\à\\ðw8€x‚fWG\ëoòþì¶©}%¶:«ZOP7öP\Ú\è¥\Ý\'¹61˜ow[\r\ÎZŒ‘»qi\ÐÁ\á–·Kƒ˜LAt˜¬X1™\ãCi\×`±0\è\êeI¥^\\c\Ýsdu ‡-;J°²t¨.Qök\ÎCi†7\Ï1\Zôø¯8\ì4ó\ä\Ø)\æk\ãôÛ¨€~\0­\ìnj`\Ì	\Î7u\nÏ©•\Ù&ß”\ë31ôSj<CrþR]—}õ¢zž¢ªÁ4÷\éòŸ=<•_i1™]O|\æ6\à{¿\'aù‡\æ\']/ñ!.mŒÆ£óZ,9\rÊºkM¦M|\Üc\Ñ´ƒg5•ó45Ú·\ÝvîŠ¥Õ„oZ˜\âtÿ\0\n\×9ñ»‹:C)\0ø%…±+]¨\êu*\Ì\ã(¶\Íc@\"\Õx’\ßzF³#\Õ!\à+N\æKwM\ãq[\è\âœ\×	ˆ-± ‚\ã$\Û]÷à¦•\ZW–&;\Ô\Ú\0Z›šPlE\Ý{”x\ÂÓŠ\ÆÀi,:\Ãy/s¢R\Ãm:o2Nü\Ú\0ˆ[«\íö†09\î$;(¸11¦¤]gðp÷ñ#\ì³\Ú8v¹“Lûü»\à‹øˆ\ÑSQ¬df°nFe1¿fUk[XØ´	³´;Œ‹ÁP±xPó I#3[q:HÈŒ—¡„Z\Ø\ëbwþ\È[°õ¤E\í\Ï\É\ÎRF\Ç\Ð\Ç9¤Á}ŒF\â\ÙLD—ÁY\Ô\Æ\Ò\Í\ß\Ë\âV¦Ò³r¹\Ã\Ú©\Ì\ZopÁs£Vâ¿°±´pòZŽW›AñZ\êR†±².`ö‚<\çz¹®ÀüŽ\"\å \Û\ÔsQ\ë\áš\é\ÆS¸\âc!.]”þØ¼–E\ìð£Ua‘ú¸q\ã~*~9,tƒ\â.´\Ö°\á\éõM‹\ÏFŠ±Gº\çn!(PlOTù\Ú_ÿ\0;ˆO˜”‰CN¥t<ilWš²\Åü†-‹Œ\Ê[À»\ê>i‡ð^\æ“\ï\è~Z¤¼7ºÞŸ2›°u;´\êEóe<\à«â½•x³n8X\Õ\î¶\ãÓ‰\â³\Â\ÓÍšF\ãû(·ò›\È\'\æ¡Ô§\ì\ê÷N°¡OV…\Ò\r1-°ðž:,¶§øq\\ó¿\Ã\ÍJu&¸D˜ªú/\ËP8juñ\è\å\Õ\â³\Øtkœò7ðÜ²­ˆ \ÏG¿÷F\Þhµ@ ’du¾2«0®$L\Úß²¦1R!m\ãÁ€\Õk\ÚC„\Ø\×\Ôk¸š¤Ú”i\Ôan`-yŽ^?(\Ì[ ‰#–«lŠ€H½\çB°¡_¢\ç$\ÓB¦2ŽSXZš\íÿ\05aŽÅ˜ˆ„\ÝWø«×£‘4“è“\Åep˜ÆªÆ£ ™°\ãE@^A‘¹YÓ¨^I€8t\ÇPŸXI\Âa\\\èkK¡\Æ,;\Æt\r\ëÄ®ƒ°p\r£Oøn\0\Í\Ý\ïf!×¼\Â\Éo`Ñ—wNR\ÖwL¹¬›\ï‡Ï²T hÀm¸ÀóR_-X[Uj=üŒ¬wtˆp-™\Ì\"~¾UÒ¥9\íhˆ. È´ˆ¥c«:“i\åwuñ\Ý7€cŠÎ¦\Ù\Ä¸\èn¤C½v,{\Ö\ï³]\àÀ\è½Ybpn a•	—\\\â¼O\ÍôkOÿ\Ù',NULL),('pepe@mail.com','1234','Hola, amigos , soy pepe','pepe','@pepe',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-01 13:40:05
