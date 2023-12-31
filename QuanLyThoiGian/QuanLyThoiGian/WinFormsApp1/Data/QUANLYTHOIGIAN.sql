PGDMP                         {            QLTG    15.3    15.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                        1262    16398    QLTG    DATABASE     ~   CREATE DATABASE "QLTG" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Vietnamese_Vietnam.1252';
    DROP DATABASE "QLTG";
                postgres    false            �            1259    16417    congviec    TABLE       CREATE TABLE public.congviec (
    tencv character varying(50) NOT NULL,
    thoigianbd timestamp without time zone,
    thoigiankt timestamp without time zone,
    trangthai character varying(5),
    diadiem character varying(50),
    ghichu character varying(100)
);
    DROP TABLE public.congviec;
       public         heap    postgres    false            �            1259    16427    lich    TABLE     ]   CREATE TABLE public.lich (
    dmy date NOT NULL,
    hms time without time zone NOT NULL
);
    DROP TABLE public.lich;
       public         heap    postgres    false            �            1259    16448 	   nguoidung    TABLE     �   CREATE TABLE public.nguoidung (
    id integer NOT NULL,
    ho character varying(40),
    ten character varying(10) NOT NULL,
    gioitinh character varying(4),
    ngaysinh character varying(10),
    diachi character varying(50)
);
    DROP TABLE public.nguoidung;
       public         heap    postgres    false            �            1259    16447    nguoidung_id_seq    SEQUENCE     �   CREATE SEQUENCE public.nguoidung_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.nguoidung_id_seq;
       public          postgres    false    220            !           0    0    nguoidung_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.nguoidung_id_seq OWNED BY public.nguoidung.id;
          public          postgres    false    219            �            1259    16432    nhacnho    TABLE     �   CREATE TABLE public.nhacnho (
    ten character varying(20) NOT NULL,
    noidung character varying(50),
    thoigian timestamp without time zone,
    trangthai character varying(5)
);
    DROP TABLE public.nhacnho;
       public         heap    postgres    false            �            1259    16422    sukien    TABLE       CREATE TABLE public.sukien (
    tensk character varying(50) NOT NULL,
    thoigianbd timestamp without time zone,
    thoigiankt timestamp without time zone,
    trangthai character varying(5),
    diadiem character varying(50),
    ghichu character varying(100)
);
    DROP TABLE public.sukien;
       public         heap    postgres    false            �            1259    16412 
   thongtintk    TABLE     p   CREATE TABLE public.thongtintk (
    tentk character varying(30) NOT NULL,
    matkhau character varying(20)
);
    DROP TABLE public.thongtintk;
       public         heap    postgres    false            y           2604    16451    nguoidung id    DEFAULT     l   ALTER TABLE ONLY public.nguoidung ALTER COLUMN id SET DEFAULT nextval('public.nguoidung_id_seq'::regclass);
 ;   ALTER TABLE public.nguoidung ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    220    220                      0    16417    congviec 
   TABLE DATA           ]   COPY public.congviec (tencv, thoigianbd, thoigiankt, trangthai, diadiem, ghichu) FROM stdin;
    public          postgres    false    215   �                 0    16427    lich 
   TABLE DATA           (   COPY public.lich (dmy, hms) FROM stdin;
    public          postgres    false    217   �                 0    16448 	   nguoidung 
   TABLE DATA           L   COPY public.nguoidung (id, ho, ten, gioitinh, ngaysinh, diachi) FROM stdin;
    public          postgres    false    220                    0    16432    nhacnho 
   TABLE DATA           D   COPY public.nhacnho (ten, noidung, thoigian, trangthai) FROM stdin;
    public          postgres    false    218   S                 0    16422    sukien 
   TABLE DATA           [   COPY public.sukien (tensk, thoigianbd, thoigiankt, trangthai, diadiem, ghichu) FROM stdin;
    public          postgres    false    216   p                 0    16412 
   thongtintk 
   TABLE DATA           4   COPY public.thongtintk (tentk, matkhau) FROM stdin;
    public          postgres    false    214   �       "           0    0    nguoidung_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.nguoidung_id_seq', 21, true);
          public          postgres    false    219            }           2606    16421    congviec congviec_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.congviec
    ADD CONSTRAINT congviec_pkey PRIMARY KEY (tencv);
 @   ALTER TABLE ONLY public.congviec DROP CONSTRAINT congviec_pkey;
       public            postgres    false    215            �           2606    16431    lich lich_dmy_hms_pk 
   CONSTRAINT     X   ALTER TABLE ONLY public.lich
    ADD CONSTRAINT lich_dmy_hms_pk PRIMARY KEY (dmy, hms);
 >   ALTER TABLE ONLY public.lich DROP CONSTRAINT lich_dmy_hms_pk;
       public            postgres    false    217    217            �           2606    16453    nguoidung nguoidung_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.nguoidung
    ADD CONSTRAINT nguoidung_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.nguoidung DROP CONSTRAINT nguoidung_pkey;
       public            postgres    false    220            �           2606    16436    nhacnho nhacnho_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.nhacnho
    ADD CONSTRAINT nhacnho_pkey PRIMARY KEY (ten);
 >   ALTER TABLE ONLY public.nhacnho DROP CONSTRAINT nhacnho_pkey;
       public            postgres    false    218                       2606    16426    sukien sukien_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.sukien
    ADD CONSTRAINT sukien_pkey PRIMARY KEY (tensk);
 <   ALTER TABLE ONLY public.sukien DROP CONSTRAINT sukien_pkey;
       public            postgres    false    216            {           2606    16416    thongtintk thongtintk_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.thongtintk
    ADD CONSTRAINT thongtintk_pkey PRIMARY KEY (tentk);
 D   ALTER TABLE ONLY public.thongtintk DROP CONSTRAINT thongtintk_pkey;
       public            postgres    false    214                  x������ � �            x������ � �         -  x����J�0����S��Hڮk�N�qœ��B抸�	<�/0� ;� ��S$ob�	�ӕB.����}��ZA�7��|,�i�2��B��T�\OЫ�����F����0p|��y�#+��9����� ��z\�%ɖs8��ӣԷ�-w@7�T�O�H�Wrf`Tg���
�✷�oS2VE���{1��$Q�2�ҝ������7��M4�a�E.�A��V��9�d^�~g2���A'*�DAp3Ӽ}��̀䒓k.�E-b	��u�Ѷ7�a�p��0^��t�	�            x������ � �            x������ � �         �   x�U��� D��+��J6�3Q�,����TP�n���hI����8�!k��ۡe������p�5����r��4��̬����mf�+侈�n�r�?|���&�J]�;�ᥑ�R�BҺ���H^������A����BN     