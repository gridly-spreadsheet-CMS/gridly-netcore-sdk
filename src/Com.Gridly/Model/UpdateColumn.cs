/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.21.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Gridly.Client.OpenAPIDateConverter;

namespace Com.Gridly.Model
{
    /// <summary>
    /// UpdateColumn
    /// </summary>
    [DataContract(Name = "UpdateColumn")]
    public partial class UpdateColumn : IEquatable<UpdateColumn>, IValidatableObject
    {
        /// <summary>
        /// Defines LanguageCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageCodeEnum
        {
            /// <summary>
            /// Enum EnUS for value: enUS
            /// </summary>
            [EnumMember(Value = "enUS")]
            EnUS = 1,

            /// <summary>
            /// Enum ArSA for value: arSA
            /// </summary>
            [EnumMember(Value = "arSA")]
            ArSA = 2,

            /// <summary>
            /// Enum CaES for value: caES
            /// </summary>
            [EnumMember(Value = "caES")]
            CaES = 3,

            /// <summary>
            /// Enum ZhCN for value: zhCN
            /// </summary>
            [EnumMember(Value = "zhCN")]
            ZhCN = 4,

            /// <summary>
            /// Enum ZhTW for value: zhTW
            /// </summary>
            [EnumMember(Value = "zhTW")]
            ZhTW = 5,

            /// <summary>
            /// Enum DeDE for value: deDE
            /// </summary>
            [EnumMember(Value = "deDE")]
            DeDE = 6,

            /// <summary>
            /// Enum ItIT for value: itIT
            /// </summary>
            [EnumMember(Value = "itIT")]
            ItIT = 7,

            /// <summary>
            /// Enum JaJP for value: jaJP
            /// </summary>
            [EnumMember(Value = "jaJP")]
            JaJP = 8,

            /// <summary>
            /// Enum KoKR for value: koKR
            /// </summary>
            [EnumMember(Value = "koKR")]
            KoKR = 9,

            /// <summary>
            /// Enum PlPL for value: plPL
            /// </summary>
            [EnumMember(Value = "plPL")]
            PlPL = 10,

            /// <summary>
            /// Enum PtBR for value: ptBR
            /// </summary>
            [EnumMember(Value = "ptBR")]
            PtBR = 11,

            /// <summary>
            /// Enum RuRU for value: ruRU
            /// </summary>
            [EnumMember(Value = "ruRU")]
            RuRU = 12,

            /// <summary>
            /// Enum EsMX for value: esMX
            /// </summary>
            [EnumMember(Value = "esMX")]
            EsMX = 13,

            /// <summary>
            /// Enum EsLA for value: esLA
            /// </summary>
            [EnumMember(Value = "esLA")]
            EsLA = 14,

            /// <summary>
            /// Enum EsES for value: esES
            /// </summary>
            [EnumMember(Value = "esES")]
            EsES = 15,

            /// <summary>
            /// Enum BnBD for value: bnBD
            /// </summary>
            [EnumMember(Value = "bnBD")]
            BnBD = 16,

            /// <summary>
            /// Enum BgBG for value: bgBG
            /// </summary>
            [EnumMember(Value = "bgBG")]
            BgBG = 17,

            /// <summary>
            /// Enum ZhHK for value: zhHK
            /// </summary>
            [EnumMember(Value = "zhHK")]
            ZhHK = 18,

            /// <summary>
            /// Enum CsCZ for value: csCZ
            /// </summary>
            [EnumMember(Value = "csCZ")]
            CsCZ = 19,

            /// <summary>
            /// Enum DaDK for value: daDK
            /// </summary>
            [EnumMember(Value = "daDK")]
            DaDK = 20,

            /// <summary>
            /// Enum NlNL for value: nlNL
            /// </summary>
            [EnumMember(Value = "nlNL")]
            NlNL = 21,

            /// <summary>
            /// Enum FiFI for value: fiFI
            /// </summary>
            [EnumMember(Value = "fiFI")]
            FiFI = 22,

            /// <summary>
            /// Enum FrFR for value: frFR
            /// </summary>
            [EnumMember(Value = "frFR")]
            FrFR = 23,

            /// <summary>
            /// Enum FrCA for value: frCA
            /// </summary>
            [EnumMember(Value = "frCA")]
            FrCA = 24,

            /// <summary>
            /// Enum ElGR for value: elGR
            /// </summary>
            [EnumMember(Value = "elGR")]
            ElGR = 25,

            /// <summary>
            /// Enum HeIL for value: heIL
            /// </summary>
            [EnumMember(Value = "heIL")]
            HeIL = 26,

            /// <summary>
            /// Enum HiIN for value: hiIN
            /// </summary>
            [EnumMember(Value = "hiIN")]
            HiIN = 27,

            /// <summary>
            /// Enum HuHU for value: huHU
            /// </summary>
            [EnumMember(Value = "huHU")]
            HuHU = 28,

            /// <summary>
            /// Enum IdID for value: idID
            /// </summary>
            [EnumMember(Value = "idID")]
            IdID = 29,

            /// <summary>
            /// Enum JwID for value: jwID
            /// </summary>
            [EnumMember(Value = "jwID")]
            JwID = 30,

            /// <summary>
            /// Enum LvLV for value: lvLV
            /// </summary>
            [EnumMember(Value = "lvLV")]
            LvLV = 31,

            /// <summary>
            /// Enum MsMY for value: msMY
            /// </summary>
            [EnumMember(Value = "msMY")]
            MsMY = 32,

            /// <summary>
            /// Enum NoNO for value: noNO
            /// </summary>
            [EnumMember(Value = "noNO")]
            NoNO = 33,

            /// <summary>
            /// Enum PtPT for value: ptPT
            /// </summary>
            [EnumMember(Value = "ptPT")]
            PtPT = 34,

            /// <summary>
            /// Enum RoRO for value: roRO
            /// </summary>
            [EnumMember(Value = "roRO")]
            RoRO = 35,

            /// <summary>
            /// Enum SkSK for value: skSK
            /// </summary>
            [EnumMember(Value = "skSK")]
            SkSK = 36,

            /// <summary>
            /// Enum SvSE for value: svSE
            /// </summary>
            [EnumMember(Value = "svSE")]
            SvSE = 37,

            /// <summary>
            /// Enum TlPH for value: tlPH
            /// </summary>
            [EnumMember(Value = "tlPH")]
            TlPH = 38,

            /// <summary>
            /// Enum ThTH for value: thTH
            /// </summary>
            [EnumMember(Value = "thTH")]
            ThTH = 39,

            /// <summary>
            /// Enum TrTR for value: trTR
            /// </summary>
            [EnumMember(Value = "trTR")]
            TrTR = 40,

            /// <summary>
            /// Enum UkUA for value: ukUA
            /// </summary>
            [EnumMember(Value = "ukUA")]
            UkUA = 41,

            /// <summary>
            /// Enum UrIN for value: urIN
            /// </summary>
            [EnumMember(Value = "urIN")]
            UrIN = 42,

            /// <summary>
            /// Enum ViVN for value: viVN
            /// </summary>
            [EnumMember(Value = "viVN")]
            ViVN = 43,

            /// <summary>
            /// Enum AfZA for value: afZA
            /// </summary>
            [EnumMember(Value = "afZA")]
            AfZA = 44,

            /// <summary>
            /// Enum ArAE for value: arAE
            /// </summary>
            [EnumMember(Value = "arAE")]
            ArAE = 45,

            /// <summary>
            /// Enum ArBH for value: arBH
            /// </summary>
            [EnumMember(Value = "arBH")]
            ArBH = 46,

            /// <summary>
            /// Enum ArDZ for value: arDZ
            /// </summary>
            [EnumMember(Value = "arDZ")]
            ArDZ = 47,

            /// <summary>
            /// Enum ArEG for value: arEG
            /// </summary>
            [EnumMember(Value = "arEG")]
            ArEG = 48,

            /// <summary>
            /// Enum ArIQ for value: arIQ
            /// </summary>
            [EnumMember(Value = "arIQ")]
            ArIQ = 49,

            /// <summary>
            /// Enum ArJO for value: arJO
            /// </summary>
            [EnumMember(Value = "arJO")]
            ArJO = 50,

            /// <summary>
            /// Enum ArKW for value: arKW
            /// </summary>
            [EnumMember(Value = "arKW")]
            ArKW = 51,

            /// <summary>
            /// Enum ArLB for value: arLB
            /// </summary>
            [EnumMember(Value = "arLB")]
            ArLB = 52,

            /// <summary>
            /// Enum ArLY for value: arLY
            /// </summary>
            [EnumMember(Value = "arLY")]
            ArLY = 53,

            /// <summary>
            /// Enum ArMA for value: arMA
            /// </summary>
            [EnumMember(Value = "arMA")]
            ArMA = 54,

            /// <summary>
            /// Enum ArOM for value: arOM
            /// </summary>
            [EnumMember(Value = "arOM")]
            ArOM = 55,

            /// <summary>
            /// Enum ArQA for value: arQA
            /// </summary>
            [EnumMember(Value = "arQA")]
            ArQA = 56,

            /// <summary>
            /// Enum ArSY for value: arSY
            /// </summary>
            [EnumMember(Value = "arSY")]
            ArSY = 57,

            /// <summary>
            /// Enum ArTN for value: arTN
            /// </summary>
            [EnumMember(Value = "arTN")]
            ArTN = 58,

            /// <summary>
            /// Enum ArYE for value: arYE
            /// </summary>
            [EnumMember(Value = "arYE")]
            ArYE = 59,

            /// <summary>
            /// Enum AzAZ for value: azAZ
            /// </summary>
            [EnumMember(Value = "azAZ")]
            AzAZ = 60,

            /// <summary>
            /// Enum BeBY for value: beBY
            /// </summary>
            [EnumMember(Value = "beBY")]
            BeBY = 61,

            /// <summary>
            /// Enum BsBA for value: bsBA
            /// </summary>
            [EnumMember(Value = "bsBA")]
            BsBA = 62,

            /// <summary>
            /// Enum CyGB for value: cyGB
            /// </summary>
            [EnumMember(Value = "cyGB")]
            CyGB = 63,

            /// <summary>
            /// Enum DeAT for value: deAT
            /// </summary>
            [EnumMember(Value = "deAT")]
            DeAT = 64,

            /// <summary>
            /// Enum DeCH for value: deCH
            /// </summary>
            [EnumMember(Value = "deCH")]
            DeCH = 65,

            /// <summary>
            /// Enum DeLI for value: deLI
            /// </summary>
            [EnumMember(Value = "deLI")]
            DeLI = 66,

            /// <summary>
            /// Enum DeLU for value: deLU
            /// </summary>
            [EnumMember(Value = "deLU")]
            DeLU = 67,

            /// <summary>
            /// Enum DvMV for value: dvMV
            /// </summary>
            [EnumMember(Value = "dvMV")]
            DvMV = 68,

            /// <summary>
            /// Enum EnAU for value: enAU
            /// </summary>
            [EnumMember(Value = "enAU")]
            EnAU = 69,

            /// <summary>
            /// Enum EnBZ for value: enBZ
            /// </summary>
            [EnumMember(Value = "enBZ")]
            EnBZ = 70,

            /// <summary>
            /// Enum EnCA for value: enCA
            /// </summary>
            [EnumMember(Value = "enCA")]
            EnCA = 71,

            /// <summary>
            /// Enum EnGB for value: enGB
            /// </summary>
            [EnumMember(Value = "enGB")]
            EnGB = 72,

            /// <summary>
            /// Enum EnIE for value: enIE
            /// </summary>
            [EnumMember(Value = "enIE")]
            EnIE = 73,

            /// <summary>
            /// Enum EnJM for value: enJM
            /// </summary>
            [EnumMember(Value = "enJM")]
            EnJM = 74,

            /// <summary>
            /// Enum EnNZ for value: enNZ
            /// </summary>
            [EnumMember(Value = "enNZ")]
            EnNZ = 75,

            /// <summary>
            /// Enum EnPH for value: enPH
            /// </summary>
            [EnumMember(Value = "enPH")]
            EnPH = 76,

            /// <summary>
            /// Enum EnTT for value: enTT
            /// </summary>
            [EnumMember(Value = "enTT")]
            EnTT = 77,

            /// <summary>
            /// Enum EnZA for value: enZA
            /// </summary>
            [EnumMember(Value = "enZA")]
            EnZA = 78,

            /// <summary>
            /// Enum EnZW for value: enZW
            /// </summary>
            [EnumMember(Value = "enZW")]
            EnZW = 79,

            /// <summary>
            /// Enum EsAR for value: esAR
            /// </summary>
            [EnumMember(Value = "esAR")]
            EsAR = 80,

            /// <summary>
            /// Enum EsBO for value: esBO
            /// </summary>
            [EnumMember(Value = "esBO")]
            EsBO = 81,

            /// <summary>
            /// Enum EsCL for value: esCL
            /// </summary>
            [EnumMember(Value = "esCL")]
            EsCL = 82,

            /// <summary>
            /// Enum EsCO for value: esCO
            /// </summary>
            [EnumMember(Value = "esCO")]
            EsCO = 83,

            /// <summary>
            /// Enum EsCR for value: esCR
            /// </summary>
            [EnumMember(Value = "esCR")]
            EsCR = 84,

            /// <summary>
            /// Enum EsDO for value: esDO
            /// </summary>
            [EnumMember(Value = "esDO")]
            EsDO = 85,

            /// <summary>
            /// Enum EsEC for value: esEC
            /// </summary>
            [EnumMember(Value = "esEC")]
            EsEC = 86,

            /// <summary>
            /// Enum EsGT for value: esGT
            /// </summary>
            [EnumMember(Value = "esGT")]
            EsGT = 87,

            /// <summary>
            /// Enum EsHN for value: esHN
            /// </summary>
            [EnumMember(Value = "esHN")]
            EsHN = 88,

            /// <summary>
            /// Enum EsNI for value: esNI
            /// </summary>
            [EnumMember(Value = "esNI")]
            EsNI = 89,

            /// <summary>
            /// Enum EsPA for value: esPA
            /// </summary>
            [EnumMember(Value = "esPA")]
            EsPA = 90,

            /// <summary>
            /// Enum EsPE for value: esPE
            /// </summary>
            [EnumMember(Value = "esPE")]
            EsPE = 91,

            /// <summary>
            /// Enum EsPR for value: esPR
            /// </summary>
            [EnumMember(Value = "esPR")]
            EsPR = 92,

            /// <summary>
            /// Enum EsPY for value: esPY
            /// </summary>
            [EnumMember(Value = "esPY")]
            EsPY = 93,

            /// <summary>
            /// Enum EsSV for value: esSV
            /// </summary>
            [EnumMember(Value = "esSV")]
            EsSV = 94,

            /// <summary>
            /// Enum EsUY for value: esUY
            /// </summary>
            [EnumMember(Value = "esUY")]
            EsUY = 95,

            /// <summary>
            /// Enum EsVE for value: esVE
            /// </summary>
            [EnumMember(Value = "esVE")]
            EsVE = 96,

            /// <summary>
            /// Enum EtEE for value: etEE
            /// </summary>
            [EnumMember(Value = "etEE")]
            EtEE = 97,

            /// <summary>
            /// Enum EuES for value: euES
            /// </summary>
            [EnumMember(Value = "euES")]
            EuES = 98,

            /// <summary>
            /// Enum FaIR for value: faIR
            /// </summary>
            [EnumMember(Value = "faIR")]
            FaIR = 99,

            /// <summary>
            /// Enum FoFO for value: foFO
            /// </summary>
            [EnumMember(Value = "foFO")]
            FoFO = 100,

            /// <summary>
            /// Enum FrBE for value: frBE
            /// </summary>
            [EnumMember(Value = "frBE")]
            FrBE = 101,

            /// <summary>
            /// Enum FrCH for value: frCH
            /// </summary>
            [EnumMember(Value = "frCH")]
            FrCH = 102,

            /// <summary>
            /// Enum FrLU for value: frLU
            /// </summary>
            [EnumMember(Value = "frLU")]
            FrLU = 103,

            /// <summary>
            /// Enum FrMC for value: frMC
            /// </summary>
            [EnumMember(Value = "frMC")]
            FrMC = 104,

            /// <summary>
            /// Enum GlES for value: glES
            /// </summary>
            [EnumMember(Value = "glES")]
            GlES = 105,

            /// <summary>
            /// Enum GuIN for value: guIN
            /// </summary>
            [EnumMember(Value = "guIN")]
            GuIN = 106,

            /// <summary>
            /// Enum HrBA for value: hrBA
            /// </summary>
            [EnumMember(Value = "hrBA")]
            HrBA = 107,

            /// <summary>
            /// Enum HrHR for value: hrHR
            /// </summary>
            [EnumMember(Value = "hrHR")]
            HrHR = 108,

            /// <summary>
            /// Enum HyAM for value: hyAM
            /// </summary>
            [EnumMember(Value = "hyAM")]
            HyAM = 109,

            /// <summary>
            /// Enum IsIS for value: isIS
            /// </summary>
            [EnumMember(Value = "isIS")]
            IsIS = 110,

            /// <summary>
            /// Enum ItCH for value: itCH
            /// </summary>
            [EnumMember(Value = "itCH")]
            ItCH = 111,

            /// <summary>
            /// Enum KaGE for value: kaGE
            /// </summary>
            [EnumMember(Value = "kaGE")]
            KaGE = 112,

            /// <summary>
            /// Enum KkKZ for value: kkKZ
            /// </summary>
            [EnumMember(Value = "kkKZ")]
            KkKZ = 113,

            /// <summary>
            /// Enum KnIN for value: knIN
            /// </summary>
            [EnumMember(Value = "knIN")]
            KnIN = 114,

            /// <summary>
            /// Enum KokIN for value: kokIN
            /// </summary>
            [EnumMember(Value = "kokIN")]
            KokIN = 115,

            /// <summary>
            /// Enum KyKG for value: kyKG
            /// </summary>
            [EnumMember(Value = "kyKG")]
            KyKG = 116,

            /// <summary>
            /// Enum LtLT for value: ltLT
            /// </summary>
            [EnumMember(Value = "ltLT")]
            LtLT = 117,

            /// <summary>
            /// Enum MiNZ for value: miNZ
            /// </summary>
            [EnumMember(Value = "miNZ")]
            MiNZ = 118,

            /// <summary>
            /// Enum MkMK for value: mkMK
            /// </summary>
            [EnumMember(Value = "mkMK")]
            MkMK = 119,

            /// <summary>
            /// Enum MnMN for value: mnMN
            /// </summary>
            [EnumMember(Value = "mnMN")]
            MnMN = 120,

            /// <summary>
            /// Enum MrIN for value: mrIN
            /// </summary>
            [EnumMember(Value = "mrIN")]
            MrIN = 121,

            /// <summary>
            /// Enum MsBN for value: msBN
            /// </summary>
            [EnumMember(Value = "msBN")]
            MsBN = 122,

            /// <summary>
            /// Enum MtMT for value: mtMT
            /// </summary>
            [EnumMember(Value = "mtMT")]
            MtMT = 123,

            /// <summary>
            /// Enum NbNO for value: nbNO
            /// </summary>
            [EnumMember(Value = "nbNO")]
            NbNO = 124,

            /// <summary>
            /// Enum NlBE for value: nlBE
            /// </summary>
            [EnumMember(Value = "nlBE")]
            NlBE = 125,

            /// <summary>
            /// Enum NnNO for value: nnNO
            /// </summary>
            [EnumMember(Value = "nnNO")]
            NnNO = 126,

            /// <summary>
            /// Enum NsZA for value: nsZA
            /// </summary>
            [EnumMember(Value = "nsZA")]
            NsZA = 127,

            /// <summary>
            /// Enum PaIN for value: paIN
            /// </summary>
            [EnumMember(Value = "paIN")]
            PaIN = 128,

            /// <summary>
            /// Enum PsAR for value: psAR
            /// </summary>
            [EnumMember(Value = "psAR")]
            PsAR = 129,

            /// <summary>
            /// Enum QuBO for value: quBO
            /// </summary>
            [EnumMember(Value = "quBO")]
            QuBO = 130,

            /// <summary>
            /// Enum QuEC for value: quEC
            /// </summary>
            [EnumMember(Value = "quEC")]
            QuEC = 131,

            /// <summary>
            /// Enum QuPE for value: quPE
            /// </summary>
            [EnumMember(Value = "quPE")]
            QuPE = 132,

            /// <summary>
            /// Enum SaIN for value: saIN
            /// </summary>
            [EnumMember(Value = "saIN")]
            SaIN = 133,

            /// <summary>
            /// Enum SeFI for value: seFI
            /// </summary>
            [EnumMember(Value = "seFI")]
            SeFI = 134,

            /// <summary>
            /// Enum SeNO for value: seNO
            /// </summary>
            [EnumMember(Value = "seNO")]
            SeNO = 135,

            /// <summary>
            /// Enum SeSE for value: seSE
            /// </summary>
            [EnumMember(Value = "seSE")]
            SeSE = 136,

            /// <summary>
            /// Enum SlSI for value: slSI
            /// </summary>
            [EnumMember(Value = "slSI")]
            SlSI = 137,

            /// <summary>
            /// Enum SqAL for value: sqAL
            /// </summary>
            [EnumMember(Value = "sqAL")]
            SqAL = 138,

            /// <summary>
            /// Enum SrBA for value: srBA
            /// </summary>
            [EnumMember(Value = "srBA")]
            SrBA = 139,

            /// <summary>
            /// Enum SvFI for value: svFI
            /// </summary>
            [EnumMember(Value = "svFI")]
            SvFI = 140,

            /// <summary>
            /// Enum SwKE for value: swKE
            /// </summary>
            [EnumMember(Value = "swKE")]
            SwKE = 141,

            /// <summary>
            /// Enum SyrSY for value: syrSY
            /// </summary>
            [EnumMember(Value = "syrSY")]
            SyrSY = 142,

            /// <summary>
            /// Enum TaIN for value: taIN
            /// </summary>
            [EnumMember(Value = "taIN")]
            TaIN = 143,

            /// <summary>
            /// Enum TeIN for value: teIN
            /// </summary>
            [EnumMember(Value = "teIN")]
            TeIN = 144,

            /// <summary>
            /// Enum TnZA for value: tnZA
            /// </summary>
            [EnumMember(Value = "tnZA")]
            TnZA = 145,

            /// <summary>
            /// Enum TtRU for value: ttRU
            /// </summary>
            [EnumMember(Value = "ttRU")]
            TtRU = 146,

            /// <summary>
            /// Enum UrPK for value: urPK
            /// </summary>
            [EnumMember(Value = "urPK")]
            UrPK = 147,

            /// <summary>
            /// Enum UzUZ for value: uzUZ
            /// </summary>
            [EnumMember(Value = "uzUZ")]
            UzUZ = 148,

            /// <summary>
            /// Enum XhZA for value: xhZA
            /// </summary>
            [EnumMember(Value = "xhZA")]
            XhZA = 149,

            /// <summary>
            /// Enum ZhMO for value: zhMO
            /// </summary>
            [EnumMember(Value = "zhMO")]
            ZhMO = 150,

            /// <summary>
            /// Enum ZhSG for value: zhSG
            /// </summary>
            [EnumMember(Value = "zhSG")]
            ZhSG = 151,

            /// <summary>
            /// Enum ZuZA for value: zuZA
            /// </summary>
            [EnumMember(Value = "zuZA")]
            ZuZA = 152

        }


        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name = "languageCode", EmitDefaultValue = false)]
        public LanguageCodeEnum? LanguageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateColumn" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="languageCode">languageCode.</param>
        /// <param name="name">name.</param>
        /// <param name="numberFormat">numberFormat.</param>
        /// <param name="selectionOptions">selectionOptions.</param>
        public UpdateColumn(string description = default(string), LanguageCodeEnum? languageCode = default(LanguageCodeEnum?), string name = default(string), NumberFormat numberFormat = default(NumberFormat), List<string> selectionOptions = default(List<string>))
        {
            this.Description = description;
            this.LanguageCode = languageCode;
            this.Name = name;
            this.NumberFormat = numberFormat;
            this.SelectionOptions = selectionOptions;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NumberFormat
        /// </summary>
        [DataMember(Name = "numberFormat", EmitDefaultValue = false)]
        public NumberFormat NumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets SelectionOptions
        /// </summary>
        [DataMember(Name = "selectionOptions", EmitDefaultValue = false)]
        public List<string> SelectionOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateColumn {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberFormat: ").Append(NumberFormat).Append("\n");
            sb.Append("  SelectionOptions: ").Append(SelectionOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateColumn);
        }

        /// <summary>
        /// Returns true if UpdateColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateColumn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    this.LanguageCode.Equals(input.LanguageCode)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumberFormat == input.NumberFormat ||
                    (this.NumberFormat != null &&
                    this.NumberFormat.Equals(input.NumberFormat))
                ) && 
                (
                    this.SelectionOptions == input.SelectionOptions ||
                    this.SelectionOptions != null &&
                    input.SelectionOptions != null &&
                    this.SelectionOptions.SequenceEqual(input.SelectionOptions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LanguageCode.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NumberFormat != null)
                {
                    hashCode = (hashCode * 59) + this.NumberFormat.GetHashCode();
                }
                if (this.SelectionOptions != null)
                {
                    hashCode = (hashCode * 59) + this.SelectionOptions.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
