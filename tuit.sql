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
INSERT INTO `usuarios` VALUES ('bea@mail.com','1234','Hola, amigos, soy bea','bea','@bea',NULL,NULL,NULL,NULL),('admin@mail.com','1234','Hola, amigos','javier','@javier',NULL,NULL,NULL,NULL),('jose@mail.com','1234','Hola, amigos , soy jose','jose','@jose',NULL,NULL,NULL,NULL),('miguel@mail.com','1234','Hola, amigos, soy miguel','miguel','@miguel',NULL,NULL,'�\��\�\0JFIF\0\0\0\0\0\0�\�\0�\0	\Z\Z( %\Z!1!%)+...383,7(-.+\n\n\n\r-% %/--20-----//-/-------/----------+-----------------��\0\0\�\0\�\"\0�\�\0\0\0\0\0\0\0\0\0\0\0\0\0\0�\�\0>\0\0\0\0\0!1AQaq\"���2��\��BR\�#br����$3C�4�\�\0\0\0\0\0\0\0\0\0\0\0\0\0\0�\�\0.\0\0\0\0\0\0\0!1A\"Qa�#2Bq��\��R��\�\0\0\0?\0\�(B\0�!\0Bm�@08W\� -c\�3\�	\�.|_e�\\j\�}J\�Kr��\0i�%_��\��\�Q�����=\\��\r6��ټ��<��<�	66���c\'��w\�Tf\�l\n��IðZ\\\�\�O\�\�Bde�	�x��ׄ���\��\\\�\����cx\�̝�pK�\�Ե���c\�0b�\�\Zf��h���\�а�q\�\\\�ښ,���8X����Z�	U\��D�M\�Z����0�|��,�\0�흓�\�?�GU8<\n\�[���!��\�#V\�>?�\�=B`��c��\�?\�e�\�ly-\�ʒ��\0�&t}�\�\�+\�TR[%\\V٩M�o\0�\�/bv\�v<��YRwݦ:h8�S\�E�2�w�tƸ�+\�\�\n6\�Z�\�0՟�ԋ\�H0ǂ2\�ټ���t%Jz�L�<!\� �!\0B\0�!\0B\0�!\0B�\0�ڝ�0\�N��u1��Iݕ\�d{CH�Z�դj8\\Jb�\0�x��eĲ�a���:9@�\���\�ů< ���_K)�\�\�>�\�q���^�r\�\�@�᭹&&m\���h�Nʬ\�x�2����]!�������\�\������\�5$�U�<Wc\�\��`���U\����l\�4Gv\"Л\�\�O\�T���BmZ� \�7\�\�j�\�e\�A.�D\���\�bU[9r�\�j�\\#��Y\�\�fq\�ƀI\Z�\�\�\�&���Q����@�3GZ\\8;~a�<-����R�i�\0�q\�\�\��Tx�Q{ĸL�\�\�\�Xk�	�$\�\�\�\�ړ^\�\�j��]ch0|\�\�t>\����\�{*\�\�r\�j�\�\�1�\�\�i�*w���N�\�\�\�tQAk\�\�NY\0�X�\�I�(\�\�XE\�[�t��\�\�8\�\�o�\�\�*\�.�\�\��:�ik�\�\�V�\�mOo��\�\�\�RG�#\�\�Vc�38\�F\�\�\�c,M5���V\����\�(\�\�@�Z\�w�.�G|.�\�=\�s�a�;�\�H�~]j^�3�\�B�$� B\0� B\0� k\�\�k�\�\rh.\'�Jؑ�����\Z`��\�\�\\�\\�\0��?�x\�b�\���I�#S\�b��\�$4x44x/;2�\�\Z���3=bT<3sM\��\0|SV\�\�Ś\�\�\�p>�\"\�%�\�))�\�\�W#�ԝ�n�\�v�\�5_2H\�GBy�\�<c\�A��/$����;�$\n\�.9N��]cǊ�\�\�yV���\�\�.6?aL�\�$�\�|>jk4#���ȩ��-hdpT�D�]��ݜ�Hw���\�drQ�\�2\�\�\0\�)\�\�T\�KN�>�A\'�!\�\��\�\�\�s\�\�&�J[�WFK�,K\�{�6\�@�\�.�@��\�EJ\�$���L\��32_$\�]\Z�\06����\�\�Q���\��\"j��|�\�/�\�X\n�e@GC\�t�\�m\"kDO���Q�U\�\�NS�5\0�����c\�$r�ӨI��)\�o�\�S�N�^։|��FBAB\0� B\0� B\0�v\�b)ӛR�O�Tu�\�2�rΉ\�l\�\�H7�L��\�\�7�m1\�\���k�%6l\Z�؁��Kԩ\0��\�\0N�\�\�f\Z�iS�\0`L�aI{Y��C\r���R}\'we\�x�6	ll���\�﻿����\�e0��]Q�٢G��Vuj��Vkr��n\�\�g�9�\�\�M��֥\�if2\�\�sƭ\�.5[6>֨涘!�\�)�Gx^\�h\�<�`a̗So��U*C-6�8]P\�ޢ�W�\�\�\�\�3����@Hx�3(��:�\��N�a�\�\�0-����i�\�p��XU\�S�ݨ�\��W\�\�۔-I\'\�H�\��Sɟ\�w��\�M{� N�\��\����Jf��p\�\���/pX*t\�/�7Nv�[\�Ec6fR�\�5y\�\���\�\r�\"~�\�v\�Ć��ڏ�\�b�\��\�\�.Z\�\�ģdN�\�\'�\0\�\�\��OK�v\�\�k�Cdi\�K�VCy?�B$\��!\0B\0�!\0B\0�!\0\n����\�c�\�l\�\r{Z��F����~�+ƏSi\�>|\�g��LSp�}���\�^����\�6ژ��ʮuG�\�h�\�\'\�rc\�\�ݭ_=\�\�\�t�w41�v�ĸ����\�:ԯ٦+\���U\�\�ßx\�\�\���\�\�\n�Ǽ���\�n�O�d\��\"k�}L�Z�J�4\�i�\��*~��\�\�Ǭ)�f�Q\�w���W�\�\�Xz����H{�#\��e��\�o�Pq�.��h���T�6\��\0R)mgq�\�\�ރ��\�\Z6���r\�#w_��kчǇY\�uS�p��\�v��ܝ	�R\'��\�詪\�\�OO5/c\��Mq�0|\�\���)L}�¹�\�[�\�Vh\�Z\�O�;\�\�\�ͯ��\�]Q}\�\�t/\�/\�MBY�fh÷\�ׂ\�\�=3\ZZ\�\�\�t4\0@,�-\�z&�|ނ��\0�!\0B\0�!\0B\0�!\0½^\�(���=\�mk�\�tz�\�\n�[}�C�Y\0:����\�1\\˴�\�^\�R�ݿ�ԃ\�?BkZ(\�\�<\�6,�\�w�ϸ�\�\�篒��\�_R��\��\�\�T�\�\�r40pӐ\�c\��\0o\�5����f?\ZjT�\0�b�Ϋ\�w\�<7��66Ύ���\�\n�4H\�n\�1p���\�\�~\��[M��I��!V\�v}\�\�h\'xO�[Z\n�؎:)��~\�S�\��\�=ԉ-%\����XW��4\�Eŏ=\�ƥ@Uv{\Z�s}\�px��\�.k�IW�oW�\�]�)�\��;�\�\�8vQ\�c���q��\\ڴ\��\0\����	��d���\0L\Z���K�-n\�<T�߃��\��/UG,� B\0� B\0� B\0�z���\0\��\0�����>�\�.m��K�;�\�?\��v�\�\�E�$i&\�\����mJ����\�9as|W\�w\�έ�V�ݚ\���?u0c����u�\�c��\\yŀ��-��4�T\�q>\r�y\��`	5��\�o�\��\0Krx\��,5���\�Kf�*C1M�\'U	�1\�\�L_\�-b���G��J��S\\&\�h4��\�k\�\�\�\��\�V�c3\�<Gxug\�e���(:A��7�B\�i�F\�T\�Q��[\�D��\�-V��je�BW?\�T>\�\�\�<�\��\0�U�,\�Өf\�p��A�x-j�h�>Q�\�wT/\ZW���B\0�!\0B\0�!\0B\0�!\0]pKH1e�cR Λ׌G��I�+i����6깾\��44�\�<\�\�N�\�>�2�`\�Z\�`Z��E��\�R�Ӥڎ�4\r\�\�sky,Go�\�\�d\�\�h:�\�.#���I�Vݞ�\0\�\�ow�RR�3Y��?z+퓇u&��\�.���@�G(�N�8�U&��-$b��2\�\0����KS\�\�\�2� �-�C=7�uis=#\�\Zؾ`<e{Dc(�3\�Y8J<N�Y\�	/�m\�c�\�\�4ש\�\�E\����3\�<x&�5\�\�Q��\�f\�}�Zy,\�`��\�WvtDN��MP\�wɏ�k��\�\�f\�+\Z\�0�\�E�Iǰ\��\0�s\�2G걔�Q����q�i߳,\rlOz\�%M\�ˌt\�c�ل�֛\�)	W��\�ya\� ͸z&:�}\�J�ǽY�\�ɶ�	м�\�H!@�\0!@�\0!@Ơ�^\���\�Ihp$j&\��x�㟈[8ѨC�jIs�\�mM��̤\\{�\��1�_D��F�Q�\��\Z\�y\\o\'\�.\�\�S%\�a3��e\�8\r�7�}�T�|�\�Ď?f�6�g(;�\��W�u*\�\�A��\�t4�7N�p\r8w\�T�\�9s\�@./0\0s6$@\�~�^3\�1��T5���Q�\�6>��PUEM��S\�\�\�\�Q�mSD�:Cs\0\�A\�i�ײ�\�\�l�\�\���{b���kU�_\�l\�U٦�cZ��i�nI\�Vt\��*`44n��1X6��E�\�U�\�\�\�p$�ng�[�V��\0uI��i!�F\"�3\�i\�x��5\�\�gN��p����]�r\���8��^y)5�W\�x\��\�0a6��v�\�\�\�:��IvSv�\�mG$\�\�h�/�\�\��r\�\�\�Z��\�Cm�k\���)lۃ{|�L���ù�R[�k}\�y�S�\�\��\�Ń�(\�\�G	ᢒ\nD\�\�\�\�C��ٻHL8���\�x�\0�o\'\�%�+�h�B�Y��zFB�B\0�|\�EG�	&\0J[w�.\0��n�\��\�H��ԻU2�\�\'\�M�\�	\��-\�>!mͲ\�;8`c�$8Y\��N�*�nm�8�6\�>��\�X�\�2\�\�W1�-\�\�\�\�\�\�D*\�\�\���Ι\�Y$\��U5��\�\�i�)=\�e����\0 �\��\"g\�\�\Z�Ct{�;=8�_�P��}�\�X\�S�?+\\\0�7\�_�E�\�\�y�h6\"d\��?u\�\�䖬;eF��\�\�\�5\�.\rfW����\�ޔ����{2�37���;:�.uF�\�s2#0��fۺ/\�>�Z��ONd�(Y��P�\�\�;\�pkG\0y�Ɋ\�L>A��\�\�y\0R�\�� ظT���\�e����d\�#H\�\�BsظG{z\�5R2�\\���<\�\��)\�H�G�\�`\0�6do\�\n���\�>\�fo�\�̍#O�M\�\�.��\�g�KOr\�\�%�@\�Ӄ\�_\�q@4f\�`\�5MY�s�;g��&2�\�C��}��1_]�CZ�{\�9\�f��k��p\� ��s�\�\0��yʰ\�5{�N�W*\�֔�Ell�y�\�\��^`�\�\�\�2-\0\��F\���f�\'��U5\\\�A& \�I���M�p�<o�{]�z#��\�\�\�.\�k�$\�\� ߑ\\\��\�\�\�\'t�\�\�fc\\\�\�\��?�g\��vЃ-\�\�_Dπ\�-�9�\�\�^\�ĐG{���\���&5�pip�\�\'��~;ľU˃d^U9!\�]\'H���.\�\�\��t/J�\�[T��\�\�\�M\�F��c+�\�X���\�:��e�.u���\0�d�!;������-��4q\�\�蔻@�[QÏ��\�E\�\�9L\�\�R�8���\�mBb\�\�\�-�3�\�Z#N�\nY�f$|��\�̯\�9�\��\"3�\���\�Xz֚\Z��k�:_P��:\�2\�\�2\�Oy�Ϛ\�B�.o�\�\�8\�p;�[�N4\�\������$��G3]Z:&}��mїM\��R\�ޡ�\�-k9\�:^~���\Z�w; ���\\�V\�a``N�\��+Uf�hr\�1\�\�	\�=#\�A?esv}*ud4D�\�\�O.\rkCl\� [+u�ʃ\�}�\��\�\�EhV\rq�$\�ӚӔ��F)z5\�\\HcO��\0t���&uSv�\����\��\r7f#qWMy~\�\�x\�ؘ�\�}\�>����\rm��u\��\�\�?�Z\�\nf��̹�\�\\��ˣqE�\�A�u�ܥЩ�<y]��r\�?\�\�\�*h�=\�m���Qؖ�ƦYc\�`���k2�b\"OI*�\nd:��,~��ߨs@��\��\Z=�<����e\�p�QM7�V\r�3�\�F�\0+�\�M���N���\�\�qq����*�v-X=�\�6$\��\��\Zn�X\�>�\�\�`b\������\�\"�WV��~\�ge\�x\�R�.\�o\�\�ǭ���ٽ�\�,-\080w�z�U�y��%\'\�ȳğ7\�t?\���7;��\\\�nm=I��\�$\�\�\�fVeJ\�\�s�O\�/�>v��E~\ryLц\�\�\Z�F\�a�Ux�S��\�;´�T<@?�.=ߢ����\�F\�uD�{g@�\�w*\�N���\�f,6$n�znQ\�S�\��\�TJ\�\��ʷ9=苉�\�s\rF�5�\�3*}[u\��Q��!\�\�#^\��2y\�;Cf\�S���\�l\�\�ê�.I�(컮���?ee�hf\�\�\'ގ�O�\�\�7\�Ep_J*\�\�?�E�:\\�A\'y��NJ\�2��\\:�4�\�s�\�I�ﲙ#\��Q*�:��������qN��iq\�\�\�W\�p�\���\�\�!d[\�ˋH��9�~�KĶL\�\"GM詆��u�\���K�EF�e{DƲ�\�)|��_�c��\�\�w\np�\Z6��3\�TZ\�X�#���VT\��>���\�\�th�\�׶�40Hݮ\�5mN�.#�s\���Qa%����򊀐7n\�,��\�gD�z���>\�R!\�\�ˌ�\0v�|�#`yA�q�Pv\�!Q�s\��ƿ}W�>X�%4\�\�d�/\�X��\��\�\'�&}J�\�8�\�yq�\�\�Y\�g�\�sI�\"\'���k\"��?�	�\0Ţ$�*u:�I\�B�q!\�\�_��J�-p\��B�q\Z��o��q�M��Ysn��Ǉ��\0hq`\�wv����\�v\�%\�a�Quu\�hZ�w�\���ٞ ����!��\��\�\��B\�*5\ZI\�M\������N<>\�v\�[�Ԍe<�e��#�U\�i/�\�@1�T���\�ٵ0�-H\�~!/W�\�d\0:h�N,$n\�\�}u�J��5\�?~i�n?B\�z}�\�\�5�\0+M\Z��)�\�c��[��;��\\.P�`j�$�ݷ;nU$�u�%ό�=�\�\�8��\���g�;�Ƃ\�=盛\�\�;�\�͐��\�T�#E*�\�E��\\���GJ+�\�\��6^!\�s���ZiHs�Ŏ�\�݉�\�g7�ûQ\��\�mQ��2ɲ!��^�\n�>8\�\�TN7x�\'��7\�a\�\�xp��,]JYS�Z��\�)���Y��H��kk�褲�\�\�E\�N�Ms5�Z\�GC\�\�n)9̀\�34�$\�\�c\�X\�\�^�L{CL[8\�[s\n\�\�\���\� ߡ�O3)\�\�\'��🊕��a���� �,ҕ&\�\��kѩl#����.�\�[��YS\�X���㸭��\�\�.0H�\�\�<�\�ᴏ9\"\�36�dy��*m�X䙈Ӕ\�Z`�Gfl\�lI�I\�8��sI\�fZ\�Hxi\�.\�\�f?L�\��O�\�=0f\�7���mR\r���\��2\�;6\�8�(�2.\�j\�\�T\�\�\�\� �i�H�Q\�S��\"t�$\�\\iiv�I? �\�\�\�x\�ou\�&��ݠq�1`�V�[\�n�g\�\�	i,�\���8p\"\�(�3h5\�9�F�P��$��z�W�6l�\�>�7=\�r.\'I����� ��*~���;U7t\�EK��]:����Q���W\0 \�\�ʐ� \�I�F\�\��5�v\���\�ʥ\�\�t�	�\ZdA�G^��j�M��\�\�\�O�\�R}\�\�-\�\�$c�D�M\�\�o$x\�1��\�p[�\0к\\�\�q$\�\�f}U�G�s���6C4�7p�\�����VgK��6O\�ݕ\'f�z\'�I�\0m�\n\�\�\\�w8�x�fWG\�o��충}%�:�ZOP7��P\�\�\�\'�61�ow[\r\�Z���qi\��\���K��LAt��X1�\�Ci\�`�0\�\��eI�^\\c\�sdu �-;J���t�.Q�k\�Ci�7\�1\Z���8\�4�\�\�)\�k\��ۨ�~\0�\�nj`\�	\�7u\nϩ�\�&ߔ\�31�Sj<Cr�R]�}��z����4�\��=<�_i1�]O|\�6\�{�\'a��\�\']/�!.m�ƣ�Z,9\rʺkM�M|\�c\���g5��45ڷ\�vՄoZ�\�t�\0\n\�9�:C)\0�%��+]�\�u*\�\�(�\�c@\"\�x�\�zF�#\�!\�+N\�KwM\�q[\�\�\�	�-� �\�$\�]�ক\ZW�&;\�\�\0Z��PlE\�{�x\�ӊ\��i,:\�y/s�R\�m:o2N�\�\0�[�\���09\�$;(�11��]g�p��#\�\�8v��L����\����\�SQ�df�nFe1�fUk[Xش	��;���P�xP�I#3[q:H�Ȍ���Z\�\�bw�\�[���E\�\�\�\�RF\�\�\�9��}�F\�\�LD��Y\�\�\�\�\�\�\�V�ҳr�\�\��\�\Zop�s�V⿰��p�Z�W�A�Z\�R���.`��<\�z�����\"\�\�\�sQ\�\�\�\�S�\�c!.]��ؼ��E\��Ua���q\�~*~9�,t�\�.�\���\�\��M�\�F��G�\�n!(PlOT�\�_�\0;�O���CN�t<ilW��\���-��\�[��\�>i��^\�\�\�~Z��7�ޟ2��u;�\�E�e<\��⽕x�n8X\�\��\�Ӊ\�\�\�͚F\��(��\�\'\�ԧ\�\��N��OV�\�\r1-��:,���q\\�\�\�Ju&�D���/\�P8ju�\�\��\�\�\�tk��7�ܲ�� \�G��F\�h�@ �du�2�0�$L\��߲�1R�!m\���\�k\�C�\�\�\�k����ڔi\�an`-y�^?(\�[ �#��l��H�\�B��_�\�$\�B�2�SXZ�\��\05a�Ř��\�W��ף�4�蓁\�ep�ƪƣ���\�E@^A��YӨ^I�8t\�P�XI\�a\\\�kK�\�,;\�t\r\�Į��p\r�O�n\0\�\�\�f!׼\�\�o`їwNR\�wL���\�ϲT h�m����R_-X[Uj=���wt�p-�\�\"~�Uҥ�9\�h�. ȴ��c�:�i\�wu�\�7�c�Φ\�\��\�n��C�v,{\�\�]\��\�Ybpn�a�	�\\\�O\��kO�\�',NULL),('pepe@mail.com','1234','Hola, amigos , soy pepe','pepe','@pepe',NULL,NULL,NULL,NULL);
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
