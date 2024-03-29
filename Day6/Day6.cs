﻿
//#define TESTINPUT
using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Day6
{
    class Program
    {

        #region input




#if TESTINPUT
        const string input = @"COM)B
B)C
C)D
D)E
E)F
B)G
G)H
D)I
E)J
J)K
K)L
K)YOU
I)SAN";
#else
        const string input = @"
1DW)H85
HCP)993
77K)LZ8
Z7Y)LWK
R2C)9XF
KB8)ZNX
KTQ)JZN
ZP1)42S
2LX)HX6
45V)JCC
36X)CQP
QBW)4YJ
6TX)SPS
C3V)1DB
ZV6)7J2
3XJ)BPB
T3Z)BC7
V7J)HM2
NRV)26V
MX4)ZBR
DDK)J9N
7XK)RK1
H6G)HRH
6N1)4NZ
YB6)NXT
T4Y)6NL
46M)3Y2
4YY)R85
8BD)4FW
LBG)LBC
YPP)89P
V1W)2TP
L2H)SQC
Q25)DWG
7PT)TH1
W27)73G
XZS)HC5
2LQ)BTD
HX6)1QS
C5W)D63
WQN)GLZ
YBD)9KC
WY3)Y96
KQ7)T1M
31T)WVD
VZP)54Q
DFD)KB7
LFD)VDG
HC6)S1B
HB4)RF7
V8R)YXM
9SB)65G
6B1)944
TQB)GPK
FMT)BM7
CL4)72D
P5H)Z6C
3J3)4Z4
M5F)P3B
HTZ)NBP
YR9)2TM
J1W)ZLG
NMJ)27M
RVV)6VM
R2P)LR9
C5G)6GG
QBT)KQ7
Q99)4DQ
1ST)KYB
BKC)PBF
R1B)FLM
H9Q)2X8
ZQ7)87D
45G)W97
CFC)ZRV
GQY)RCF
P8H)FNC
BB9)126
4TG)TW7
P3B)6VR
RT2)M2P
C4L)X5R
RSC)XTG
MG7)4HW
751)T9S
775)4SJ
44D)8V6
KLD)XDJ
T18)5ZT
FHL)973
4KX)RBB
GSM)XZF
PBG)1M3
98D)GXM
H1C)KN3
2MD)ZWV
M4P)CXL
VBZ)XK5
B89)G3M
2YV)MKQ
LFY)27S
TJ7)H58
MC9)VM6
V9V)2L3
FN3)SZV
SZY)8NW
JCJ)CQT
XK5)K3M
713)M9W
XJD)LG6
7FL)JDN
KRT)9D7
ZNM)KN8
WQY)GWM
F26)Z34
S78)RLZ
V11)SRY
VXY)87X
WMB)H4Y
CDJ)RMX
PRZ)PH3
JSR)VW9
RTZ)68X
46W)8F3
TXB)3WM
FQN)MMY
Z12)SDB
5SB)5G6
VFH)BLD
F53)L6Z
5DC)XWK
CRC)GJH
W39)GHM
Z2Q)MTD
JGZ)GCH
5Y6)9WQ
CT4)HXV
TH3)MWT
1SK)WNB
Q6C)QRW
B3Y)7C4
JVY)T18
YCD)94K
WN2)7TZ
W6Z)NTX
P8P)34Z
3R8)XPR
VJ8)CP4
LMV)3J3
D6N)71W
JTX)QML
C1X)7P3
9K7)7PK
6S2)7XK
ZJQ)1VJ
LDT)VK4
QBW)L84
S5D)QBW
5HQ)R9S
38M)HYX
34Z)SYK
TNR)QTC
PB6)CHS
HSM)FFD
88B)ZJQ
XDR)719
J9N)CHD
VZV)NDZ
28Q)ZWW
NSG)35D
8RV)Q5Q
XSG)R5T
H2W)BQ9
W6Q)K56
QML)WQN
NWF)HD7
CMW)C1S
NV9)2CK
QGK)RY4
9MV)MKP
1BK)HQY
BM6)NQC
MK4)LV1
8C7)BFQ
KH9)3LH
ND4)ZGX
JTK)49M
R3X)YCD
P9X)JTM
HYD)8FH
KB7)6GW
3CX)G3T
47C)7KX
5YR)2R4
91X)CFD
X2B)5T9
8NW)785
M8P)2PW
7KX)294
WBV)PV5
P9B)QQS
72P)9XK
Q62)979
L7L)BCX
5T9)RT2
X78)QP9
CB6)VNM
MZY)FF3
NY9)SR7
73S)WB5
K9K)R3B
R3B)Q1Z
S3T)HTF
RMK)H1C
9YD)HSM
HRP)4D8
W79)Z26
HMZ)ZP1
5BX)1SS
369)J3D
3B3)F3B
1MC)S3T
TCT)P6M
HNR)ND4
8FH)CRC
JF4)TV9
K2L)FD2
NXJ)NRV
KNL)RVV
FF3)TFS
6L3)FFV
6YK)XM8
1R1)539
MHY)BGH
XJF)Z7M
JDN)7SV
WFT)YG4
WFW)LPX
RJF)QP5
4ZC)NM1
9HD)Z12
XKT)47C
NFY)2GQ
GWM)YVD
L6S)2SY
XWK)YSJ
DR7)NDJ
SVP)HLF
38T)B3Y
6GG)8B6
1QS)86C
P5D)8T2
PBR)4PH
W19)GHS
7LM)TBL
1G7)51M
KKJ)GQ9
PPY)V59
6RY)JFR
W97)FY8
F58)Q5T
7QS)PJJ
12H)HP9
49M)GV6
ZSJ)LMV
YKT)Z37
CRB)NT2
BSG)1DV
B6L)2WC
NYT)BNR
RFC)J6L
FMZ)DN8
SX7)8VM
6VR)4YD
T4W)H2L
QNX)SXW
YX8)S2D
K3M)95P
84K)JS8
R2C)YHM
TG5)ZPD
NMR)JHM
FCW)N45
1CZ)JCJ
5G5)LFM
2J6)W79
CV4)LTY
Y96)PSM
NMN)RPH
PXM)7Z3
V59)V9B
PVQ)CRB
T1M)J94
TW1)Z7V
W1G)HWK
GJH)V9V
6JC)49Q
1XY)DYT
2WY)FN3
X4Z)G7B
VKF)3XS
B7X)PVQ
1TG)YLK
VRS)9RD
NK7)F26
2SG)XNN
R37)43B
J9W)LVR
JDX)LX4
Z35)6PF
X4H)3PZ
QP5)FKK
6ZY)5WW
539)TWH
8T2)88R
TZN)F7B
M2P)WN9
6NW)7FZ
2Z1)39Q
8VM)6BJ
4ZY)GD9
XGN)6J6
CNC)1N8
72D)KRW
LG6)2J6
973)ML1
LKF)MZZ
J3Z)2W4
71W)43K
2PZ)M8P
LZ8)7ZY
CVP)PSX
HZW)C1X
TBC)F9C
41T)CY2
7C4)HD3
6ZV)PZN
1XJ)RVQ
CQT)DYK
2V4)BTZ
P5H)X4H
HSH)YBT
BXH)BDV
J4V)CDY
HTF)7QS
89B)W1G
2JF)LQX
PRF)LMS
2RY)2SG
M8R)9LM
MPL)HC4
KJ5)D6H
LFQ)MFD
SSV)2JW
HT6)6N1
6LC)1GW
J9Z)82J
PT2)QZT
2V6)MG7
ZXQ)XZN
2SH)BB9
KGL)F2R
2DZ)1V4
WNN)JS3
L8R)Q99
BS5)FMT
3CC)T4J
2Y3)282
QP8)9FW
Z5F)DRJ
KT3)SL8
QWC)25J
VMV)6F2
MH2)9H1
6GW)HSH
TH1)XWN
H2W)CJ1
11F)5J3
NLG)TVQ
PGH)HNM
NBR)CYG
7ZY)RYY
3WK)CVP
V76)4V4
N4P)1QW
2WR)73S
89P)5DC
9XK)PPB
8W7)HH7
G6T)7LM
BGH)YS1
MTQ)8JF
QQS)XV3
RTF)P21
LRC)4XC
N52)QBT
3CS)K84
BRM)W9H
2GQ)TN3
C91)6ZK
YTN)3LW
ZGX)H9P
MTZ)32B
RCF)VQL
VZY)JH3
ZHN)M9G
2TM)6SB
2JC)JF4
DNT)VKF
HCB)Q4J
NTX)PNT
Q65)H2W
35Z)GKX
CBK)6T5
HYX)1BN
6VV)Q5J
ZJH)9DQ
WDY)9RT
ZZL)JXS
SVF)SNJ
WFN)J7P
VS5)S7D
17P)S8M
MYX)B89
W36)C71
KW6)45G
CJZ)Y7W
NZZ)WH7
DZ4)7HT
X4K)FQ5
3NX)PCN
MDY)XJF
X8L)HC7
NFY)HTB
W96)P2D
JQF)6DP
QBV)P8P
STC)GHK
ZCD)587
Z2C)8HF
PF2)ZGQ
PF2)7HL
HSD)9K7
HG2)5QL
D5R)S89
GQ9)CRZ
PTM)N65
9SB)RSC
Q58)SGL
9D7)28T
LJJ)GG9
22T)JGZ
VMQ)QXY
JJ1)9T4
49W)XNF
53W)BXY
K9K)6VV
F7B)STG
KYB)QF9
TTW)MK4
QT1)PGH
S7D)JNZ
H9P)H4F
2XT)NSG
VZW)8NX
5CG)3XJ
TN7)QP2
TL9)F53
J64)GGN
FVV)MRM
X2L)D43
669)SCY
NZP)SB4
Q3L)K27
J4C)WYY
T4J)QJ6
9LM)BS2
GSQ)6ZV
217)W6Z
RVT)59P
D63)1K8
5R3)H6G
88R)2Y9
LRC)LSX
94Y)8Z2
N45)PPJ
QB4)DBS
WXZ)86Q
F7C)2DZ
CPH)7FL
KLV)5HQ
RK1)DJC
52G)W6P
4P8)H3S
CBK)2VG
WJP)QKF
QN7)SPQ
6SB)GCT
G3M)TH3
M89)NGX
591)PMN
SGL)53W
WVN)CH4
S8M)4LJ
C18)X7D
P23)7L3
MRW)YCR
Y91)TK1
YCR)B5R
SRY)J8H
9RT)RWL
HNJ)VZV
W27)545
5VQ)74V
9K7)FCW
7GK)KTQ
P2F)D8V
PH3)4P8
COM)QST
X6X)TRB
4Z4)6YK
5Z6)ZV6
2J2)CHQ
TWG)P8H
7SV)K3T
8R8)8BD
TW7)1FD
9FR)R2P
2PW)M89
NPG)Z21
PVK)GB9
TFS)JJV
X35)6D8
82C)D19
6T5)WWX
C22)6G5
QT4)83R
VH5)YTN
TV9)XR2
2TP)6N9
67B)CX6
T5H)5RN
JXQ)R9V
RW8)NFY
XWN)CBK
G94)B7Y
B7X)48M
NNF)SFY
PWS)SVF
F7C)VZR
HRH)FGQ
GTR)YPP
GLZ)JTK
5WK)NMR
SSV)CL6
2RG)NKK
KKJ)FMF
S5D)1XJ
LLW)51F
WH7)5VG
VD8)DCC
FLM)C8K
JMR)775
CQ3)8S9
8D9)P66
PSM)KLN
47P)WN4
DX7)L3V
CQB)YL8
KG5)8W7
6ZK)QBV
CX6)RJF
CXL)FRM
NJ6)DDM
9RP)H2H
M9G)RMB
3XS)PB6
1PS)WKP
YXM)4ZC
F9X)RLL
2TP)QNX
QZ5)HBD
VK4)3V6
7N1)9FR
4NV)DHF
VGS)VH5
C8H)HCP
P87)ZN7
CQ9)NRX
RLZ)2NZ
T1L)6CM
FMF)QWM
3VL)9TH
MRM)T5H
HC4)JDW
BJZ)K9K
7HL)CMW
RCF)BYM
3SZ)TBC
1GW)YMC
M54)4G3
3PZ)J4V
S2D)1XZ
VQL)VCN
4J3)TZL
719)SJB
JKW)JWF
XTG)5VQ
7VD)VT8
M2P)VQT
GMB)W7J
94Y)JDZ
63B)CFC
8ZD)9MV
RWL)6BY
6PF)5M8
LL6)CB6
27S)LYQ
47P)82H
GV6)VXL
7R7)LPB
979)HZ2
545)4TG
Y5V)X6X
Y2X)JKG
5B4)CPH
GBN)MPL
27N)322
TSN)MHY
PDM)VS5
LN7)4N2
4HL)YYN
V7J)WNN
9DD)ZWR
T1Y)7D8
BYM)28Q
ZJN)1V3
QP2)LDT
PTM)P1X
TZ6)7HG
68X)VZG
Q1Z)44D
294)FDR
TZT)BJZ
5G6)Q65
W6J)XM4
4G3)W69
CB6)36F
DVS)52Y
VCN)WWH
SQV)RQY
6DP)3CX
ND4)T9N
K6Y)KG5
6WV)NXZ
944)ZZL
YXJ)CLV
5ZT)ZBX
84P)J5R
Q3G)6KN
GFR)SWG
VZ8)SNZ
4PH)63B
M7M)HSD
6CM)X9P
LQD)ZTD
WH7)FNR
2WC)D3P
2VL)LL6
HP9)8M8
SLZ)WJP
DQ8)BSG
HD3)CJ3
WXM)NY9
HH7)SY5
R9S)L1J
PSM)WFT
9MV)2YV
25T)CNC
HZ2)SAN
CBB)HS1
LRF)67K
LPH)YLX
35D)2L2
83F)DKX
VNR)J95
LNN)8WC
TVM)DNT
P7B)46W
6WJ)27N
J5R)W6J
LPX)8K4
NGX)J3Z
2JM)FHL
MPM)VFH
QLS)YDJ
322)HVV
YT5)Q62
WM3)KNL
4YD)MYX
L4V)G1B
7F8)9SB
1DV)2Y3
2JF)58W
4R5)MVP
YXW)QT4
X9P)7R7
8B6)62Z
NQC)WTG
3RB)XVK
HTB)VTW
XSR)5Z4
5P5)LYG
MZZ)6L3
B7Y)L85
9QL)VZP
7ZT)BXH
47C)MSN
ZWR)PTM
VKR)P9X
65G)2NL
2NL)TN7
DKX)YXW
CVZ)W8S
TRB)8YJ
L85)FD3
F3Q)PW8
7WB)82X
2MD)T4W
Q2J)3RB
MRR)3GT
6N9)6ZY
8HY)MJP
RLL)HTZ
74V)WQ3
5MJ)KLD
7TN)R2C
DBS)CZH
5FF)V1W
9T4)NZP
H5Y)NN7
1MT)L7R
WWX)DL4
R85)818
QCM)DBH
LBG)1XY
RQ7)7F8
J6N)YLL
7ZN)GTR
JH3)GNW
4JF)MBC
ZWW)NNK
W7J)HNC
TF8)1DF
6XQ)VX1
M5M)17N
39Q)2WR
M3W)X4K
6XS)PXM
7HG)TGY
4VS)TGV
J95)JVY
HGZ)BS5
W1T)WV6
83X)NYW
JPV)STX
QM6)LSW
8S9)P7B
5CG)WL9
VDM)GDN
DL4)W1T
K6Q)NWF
CRL)58Z
CDY)5NC
QFN)8KY
NMV)TT6
G2G)JSR
YL8)217
VFD)YB6
F3Q)9X9
Z37)4M2
FD2)D46
LGM)DVS
WWH)GSQ
6ZF)M4P
QZT)DZ4
WB5)GFQ
P8H)1TH
136)NGS
ZWV)TG5
DYT)WKJ
7TZ)T24
XDJ)9RZ
WL7)FJM
JKZ)2VL
BM7)2RH
59P)3R9
JCC)VXY
7DP)MZY
957)ZQ7
R37)GY6
CY2)93Q
GZF)NMY
GG9)YKG
DBH)1L6
GGN)L29
XVK)26R
QST)2LX
NNK)DRK
M9Q)BQ2
CDJ)N4P
G8H)QDQ
LKK)KH9
JZN)JKW
RFJ)PBK
3SP)TJS
HVV)6Q5
4HW)GZF
BFQ)5YR
QS1)VRS
L6Z)8QV
RR5)D5K
4N2)TP2
82H)TJ6
M9W)PCV
WV6)QFN
TH6)3NB
PCV)CBB
9X9)CDJ
2L2)5MJ
LVR)L1K
L3C)1QP
9F4)PN8
X78)CMZ
SDB)3NX
D8V)NYT
7L3)VNR
H8L)FMZ
FKK)6LC
5C8)MC9
9NJ)YMK
PN8)4DK
KKD)TQB
8CM)YR9
HFS)JWS
1MC)8TM
B6Q)44B
3LW)LLW
XZF)XDH
WBN)WN2
MDN)87Z
1SS)HCG
6D8)MD4
RH8)GP8
28T)1SK
914)GYS
6L5)3CC
QW2)Z7Y
TN3)QCM
RF7)751
MC3)BP9
BXR)5P5
GV6)NN8
5Z4)WFW
TVR)9YP
Z26)ZJH
2WC)TZ6
34R)89N
JM3)C5K
WG9)35M
VQL)Z7W
73G)RTZ
JDW)QLY
TGY)JKZ
BSJ)CTK
Y8H)XRK
72P)VGZ
PSX)F1H
X7D)2WG
7ZT)PT2
XR2)N6W
4YJ)BDD
LDX)2M4
P66)SX4
VZR)CV4
LV1)JVW
CFD)YQL
51M)VY6
FNR)T67
9WQ)LKB
J16)PM4
SSK)QM6
C5K)C4S
BNR)717
SR7)64J
JYH)G6T
GXM)CRK
KC8)WFN
ZPD)GX1
RLZ)C3V
7PK)WMB
SMF)84P
Y8V)WDY
CTZ)HNJ
Q3L)LSN
MZY)2SH
L86)LQD
HBG)2JF
ZLG)LFQ
W8S)VD8
LWK)DPS
P21)TVS
RYY)HLN
LR9)9RP
7N1)TFT
R5G)Q2J
XGB)VZY
QF4)9J3
48H)36X
RF1)9Q8
K67)QPB
VNM)ZMJ
17N)88B
FFD)VW4
WVR)MHG
4XY)9WM
LSX)QK9
LP2)XGB
XV3)SL3
KGW)GSM
VGZ)FJZ
25J)Y1D
GCH)WQY
FJZ)7TN
YQL)QB4
BM7)GBN
2JW)7ZN
87D)T1L
P29)9NJ
5H2)49W
27M)QZ5
BDQ)726
G6F)94Y
9RZ)W59
QX4)KWJ
WQ3)1K2
V9B)ZQD
KLL)W36
J8Q)8ZD
Y18)TTW
713)K2L
BDD)P5H
TPD)WNL
MKZ)C18
NVB)7WB
28T)N4K
ZN7)46M
3Y2)T3Z
GHM)X35
YB6)F3Q
8TM)LNN
DJC)31T
RQY)PBR
VM6)32M
MZP)Y91
CMZ)JTX
43B)MKC
8BN)CQB
YZJ)2RY
G3T)YFR
W19)51X
YXM)DQ8
JFR)3K3
3LH)SVP
GTC)4KX
6WW)NZZ
B4X)Y8V
9LM)Z2Q
SPQ)QTH
GCT)NV9
D3P)3QB
SB4)HRP
S1K)CF8
X5Q)697
PPJ)PJM
3NB)MJ3
Q34)29Q
WVN)6MX
HCG)Q25
NM1)3R8
KRW)PKY
ZGQ)WVN
K1Y)5BP
FD3)R3X
GHS)QX4
7MT)7ZT
J86)V3V
R5T)CL4
4V4)P5D
87Z)H8J
2JM)L7L
XPR)YKT
J15)TCT
95P)7WG
XM8)VMQ
9B5)CRL
2WN)Y5P
ZQD)HRX
5VN)2PZ
PWS)3SP
58Z)NW3
KW7)6WW
C5K)J16
6L3)2JM
C33)CFQ
9FW)HB4
9KC)FQN
Y5P)LFY
PBK)SMF
84P)J9Z
M34)8XN
B7Y)1ZX
CFQ)2XT
LMS)GKB
DZX)83X
7KQ)X7M
YVD)84K
2X8)PRZ
5QL)Y5V
KN8)TF8
WQ9)RVY
KD9)CJZ
6F2)CSJ
G22)XR5
Y7W)MRR
MD4)C33
DH7)HCB
87X)F58
HC5)J4C
RVY)4HL
8PX)5BJ
226)369
PZ1)9J1
6W2)QP8
HKH)42H
YBT)47P
TJS)SLX
F1H)PVK
XGN)4JF
1XZ)2Z9
67B)YKF
TBC)K7C
6SB)VGS
4RT)52G
1Z1)HZW
FMT)ZT2
RLL)YZJ
G7B)WK4
CRK)97K
QPB)1B5
49Q)W6Q
K8Q)1DW
NYW)ZWF
L84)LDX
HLN)C5W
4DK)GVM
FVV)ZZ9
C9P)QT1
W8H)JVZ
Z7V)RFJ
WMV)H9Q
5RN)Y7F
GPK)YX8
8K4)R7J
W59)J15
731)X78
1BN)914
CMZ)GYN
XRF)NBR
8JW)T4Y
CLV)838
MVP)4DT
YYZ)X14
SQN)3KV
WFW)WBN
4JF)MB7
ZT2)KLV
YG4)GFR
MTD)FC1
P6M)Z2C
9YP)Q3G
MYX)W3X
P1X)BSP
126)6S2
6DF)DHR
KBZ)T1Y
64J)LBS
8F9)J6N
9TH)21R
QS6)D6N
4LJ)5CG
4PJ)PWS
NXZ)GZK
LRZ)XDR
1V3)Q3L
PRF)7WP
D19)3CS
646)Q58
FV9)WQ9
8WC)5H2
MHG)TL9
HD7)8JW
K6Q)HFS
RQY)TPD
NMY)1ST
5MY)X2K
J1W)4R5
1DF)LM2
Z7M)KGK
LKB)F9X
SYK)Z17
YVD)8GB
26R)ZJN
3QB)FLK
NRX)521
KN3)M34
SX4)F6D
XDH)8ND
PKY)NQ8
282)PBG
GYN)Q34
9J3)2K9
5SV)KGW
YYN)M5B
YMK)HMZ
1L5)JQF
1ZX)KC8
M98)29W
YHM)8HY
HQY)6ZL
VZP)WY3
PLB)HNR
JRJ)CQ3
521)5JJ
GJR)NJ6
WG9)ZCD
1QW)2RG
8KY)HKH
79K)M8R
NBP)R6X
7HT)VMV
JJ8)V8R
2CC)YMQ
N63)2LQ
44B)7CG
62Z)SZY
1V4)LN7
STG)C22
W1H)8CB
GY6)MTQ
LTY)PPY
1QP)2V6
5LG)SSV
3Y2)8XF
NFG)C1F
R5T)6JC
NHX)5WK
Z7V)669
Z9Z)WBV
BXP)3SZ
JWS)JSK
LBL)HC6
WSP)7GT
8QW)Y6G
C1F)6ZF
D6H)6FJ
Y7F)YT5
4VX)X75
CJB)DR7
7GK)8C7
S89)R1B
2Z9)HT6
TSN)5VY
36F)3J1
XRK)7Q5
21R)NFG
R7J)KKD
PW8)B7X
SWG)FSM
6MX)7MT
KGK)9F4
BC7)41T
QDQ)VJ8
JQK)9B5
WNB)TSL
JQF)M79
VMV)RH8
GVM)Z35
GY7)TH6
MR7)79K
MJ3)D7S
WL9)SLZ
STW)SSK
F6D)1W7
5GG)91X
51P)98D
LX4)PZ1
5WW)ZXQ
7D8)LBL
JTK)48H
CH4)QF4
CHD)NQP
CJB)713
KWJ)J86
DN8)J1W
5CC)QGS
LPB)TW1
NQF)PKH
J9N)K1Y
WNL)1TG
Y91)DDK
6FJ)957
ZBX)Z9Z
1FD)GTC
SNZ)RTF
YMC)F45
6J6)KXB
M5B)SH3
HWK)ZSJ
CSJ)HBG
SFY)NLG
KXB)W39
YRZ)LRZ
J7P)Y2X
GKX)TWG
HXV)WSG
QF9)BXW
7FZ)G6X
43K)PDM
1K2)GKY
VX1)HGC
RTQ)LHY
ZST)KBZ
T9S)JPV
DPS)5Z6
BS2)S5D
NDZ)L3C
R98)HGM
K75)2CC
V6Z)52P
82J)BKC
2SY)C9P
TVS)4ZY
48M)VBZ
9J1)8CM
361)PLB
DTW)Y6R
MSN)TJ7
G6X)77K
NYR)V6K
WKJ)ZNM
HBD)VVZ
9RD)4NV
SNJ)R37
JSK)KKJ
QKF)6W2
DRK)X4Z
GZF)VZ8
RMX)L8R
TJ6)K1C
FLK)MRW
GYS)F7C
W6P)L4V
TT6)N52
3KV)6TC
V3V)KH1
Q5J)7DP
L1K)V19
2R4)KKV
KB7)NYR
838)SMD
NN7)K8Q
WN4)3N4
82X)MX4
2M3)45V
JVW)5VN
R71)BRM
NDJ)K6Q
V6K)RR5
8HF)NNF
STC)VZW
FNC)5C8
N65)S9M
BDV)HGZ
QM6)38T
ML1)MPM
VQT)K6Y
5VY)4RT
TTW)1Z1
K56)J8Q
818)L6S
1TH)MS9
8CB)GJR
375)Y18
Q5V)MVR
SJB)CVZ
8Z2)NVT
YFJ)KJF
JWF)S22
SMD)5GG
QK9)2WN
MB7)WG9
JS3)1PS
HRX)SQN
C4S)LBG
VT8)R71
KKY)XSG
X7M)7HH
LQX)3WK
VW4)LRC
F45)1BY
1N8)SX7
K3T)XGN
6ZL)V7J
KVL)82C
35M)WSP
T9N)QW2
ZNX)GMB
CJ3)KKY
ND3)YLH
YMQ)YOU
54Q)M98
JG8)STW
K27)M5M
T6C)LKF
7CG)8L9
DRJ)M9Q
LFM)WXZ
V19)WVR
CJ1)PY1
ZBR)5B4
YFR)5C1
F3B)QLS
4NZ)9FH
97K)5LJ
HGC)79S
NXT)KW6
JJ1)4XY
4DT)KRT
BCX)Q5V
SZJ)5LG
QTH)11F
BSP)HYD
CHS)J64
Z7M)XSR
7Q5)TSN
NVT)FF6
3TT)BKZ
BM6)HG2
GFQ)4YY
9XF)YBD
MKP)C91
7J2)RFC
LBS)1MC
QRW)STC
8CY)R52
RLM)BM6
HM2)P87
TWL)FVV
9FH)2MD
3DG)4L4
P74)FV9
BHB)8R8
2CK)JXQ
BQ9)NK7
3J1)B6Q
591)V11
3SD)G8H
2K9)G22
FN9)6TX
J8L)JL6
NW3)D5R
Z34)WXM
M8P)1R1
VS5)6WV
9LV)HHL
BXW)5VH
GKB)FN9
L29)XZS
ZPD)C8H
5VG)17P
NN8)6NW
QGS)S8W
Y6G)JMR
52P)W8H
RFV)T6C
1DB)6XQ
26V)9HD
1B5)C4L
WVD)VFD
TVQ)TZM
HGM)N6D
JPV)3T5
QWM)T2W
LHY)LPH
38M)W27
QFN)G56
587)QS1
BPB)C5G
JNZ)CJB
8V6)LZH
GP8)4J3
3GT)MC3
PM4)67B
JDZ)NQF
TSL)RMK
MS9)L86
51F)25T
Q5Q)22T
WYY)KW7
C8H)51P
WFC)JJ8
88B)5RC
MJP)NMV
KLN)2JC
JJV)5G5
32B)R98
TCT)ZST
PVK)R5B
PBF)VTL
DHF)PYR
7QS)RLM
6H7)8QW
VW9)6Y8
G1B)NVB
RJF)5CC
H4F)W96
PDD)SZJ
42S)JDX
PRY)LFD
VDG)9WS
JXS)867
N4K)83F
Q5T)TNR
7WP)NHX
DZ4)97H
TGV)6DF
29W)VDM
PY1)8F9
W3X)5SB
BP9)XKT
3R9)8PX
X75)9QL
GHK)V76
N6D)9YD
PNT)J8L
3B3)PRY
DBX)5FF
VZG)MYH
Q2T)JQK
7P3)LP5
H85)TZT
1K8)WMV
J8H)G1Y
SCY)P29
CSJ)5Y6
HS1)BXP
T24)JJ1
NMV)5SV
G1Y)M3W
YS1)WM3
PJM)MKZ
NT2)1G7
DBS)NPG
QQF)591
YZX)BSJ
1BY)4RH
5VH)SQV
34R)DH7
9WM)KB8
DCC)Y8H
M34)8D9
D5R)DFD
J94)KVL
BTZ)X8L
F9C)6H7
WSG)PMC
7HH)5DJ
XWG)7KQ
K1C)7GK
6BJ)CQ9
ZZ9)KT3
KH1)LDR
W44)ZHN
FFV)BDQ
GKY)3VL
CTK)7N1
JVW)LKV
QJ6)646
LSW)LVL
HLF)X2B
Q4J)ND3
MFD)BXR
ML1)KD9
8JF)5MY
8XN)PF2
4TG)W1H
H2L)TVM
X14)QS6
3N4)LJJ
FN9)GY7
2Y9)YXJ
LKV)W44
VVZ)LFP
QXY)P74
FY8)72P
993)3SD
J3D)M9C
8F3)1BK
JS8)89B
MK4)NMJ
9C1)TXB
3WM)5R3
GDN)LGM
FSM)LXR
6W2)JRJ
4FW)RW8
GHS)BHB
ZRV)375
D5K)K75
BKZ)MDN
369)PDD
ZZL)PRF
FF6)3DG
32M)6B1
H8J)BNL
LQD)8BN
PCN)KJ5
JTX)3TT
4L4)2V4
LSN)Q2T
77K)YFJ
K84)RFV
WTG)WFC
YLK)1MT
J6L)7PT
4DQ)DX7
2NZ)2WY
BTD)KJD
9Q8)XJD
CF8)F38
9D7)361
LXR)M5F
F38)Q6C
TZM)9DD
7GT)RTQ
CL6)X5Q
HNC)12H
NQP)L2H
SL8)LRF
Y6R)43M
QP9)CT4
LRF)9LV
PJJ)DBX
5BP)P9B
QLY)S78
5DJ)136
4M2)37D
1M3)RQ7
H3S)WLZ
9P8)TVR
726)YRZ
RVQ)YVN
B5R)35Z
H58)QWC
5JJ)MTZ
NQ8)MZP
GX1)HGS
42H)M54
PV5)VKR
FRM)R5G
46W)38M
7HG)LP2
BXY)JM3
2M4)Z5F
86C)P23
Z21)MDY
LZH)N63
LVL)KGL
X2K)J9W
TJ6)XRF
6Y8)6XS
YKF)JG8
MBC)XWG
YLL)V6Z
717)TWL
43M)6WJ
Z21)TZN
9WS)MH2
PPB)YYZ
SZV)4PJ
8GB)B4X
2L3)4VS
CYG)LKK
D43)WL7
SH3)NXJ
PMN)8CY
2YV)QN7
6G5)2J2
1VJ)GQY
R5B)QQF
T2W)226
FGQ)8RV
XNN)X4Y
CRZ)MR7
ZV1)34R
5LJ)7VD
S9M)K67
54Q)G94
MWT)6L5
Z6C)W19
CP4)2M3
L86)2Z1
136)G6F
Z7W)KLL
86C)G2G
P2D)H5Y
D46)731
51X)RVT
6TC)B6L
XNF)6RY
NYW)DTW
H2H)DZX
T67)ZV1
C8K)9P8
4D8)1CZ
FJM)H8L
9DQ)9C1
8NX)3B3
TWH)QGK
CZH)5BX
7Z3)CTZ
867)P2F
8M8)NMN
STX)YZX
LP5)RF1
HYD)4VX
67K)M7M
VXL)JZ7
HGM)S1K
R52)1L5
CQP)JYH
6BY)X2L";
#endif

        #endregion
        static void Main(string[] args)
        {
            var lines = input.SplitLines();

            var orbiterData = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                var parts = line.Split(")");
                var center = parts[0].Trim();
                var orbiter = parts[1].Trim();

                orbiterData[orbiter] = center;
            }

            var totals = new Dictionary<string, int>();

            int getTotalOrbits(string orbiter)
            {
                string current = orbiter;
                if (totals.TryGetValue(current, out var cachedValue))
                {
                    return cachedValue;
                }
                else
                {
                    int nOrbitsForCurrent;
                    if (orbiterData.TryGetValue(current, out var orbiting))
                    {
                        nOrbitsForCurrent = getTotalOrbits(orbiting) + 1;
                    }
                    else
                    {
                        nOrbitsForCurrent = 0;
                    }

                    totals[current] = nOrbitsForCurrent;
                    return nOrbitsForCurrent;
                }
            }

            /*
            int totalOrbits = 0;
            foreach(var orbiter in orbiterData.Keys)
            {
                totalOrbits += getTotalOrbits(orbiter);
            }

            Console.WriteLine(totalOrbits);
            */

            var myOrbit = orbiterData["YOU"];
            var sanOrbiting = orbiterData["SAN"];

            var paths = new Dictionary<string, string[]>();
            foreach (var kvp in orbiterData)
            {
                var reachable = new List<string> { kvp.Value };
                reachable.AddRange(orbiterData.Where(kvp2 => kvp2.Value == kvp.Key).Select(kvp2 => kvp2.Key));
                paths[kvp.Key] = reachable.ToArray();
            }

            var result = Graph.ShortestDistanceBfs(myOrbit, sanOrbiting, paths);

            Console.WriteLine(result);
        }

        
    }
}
