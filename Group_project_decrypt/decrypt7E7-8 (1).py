import itertools

word1 = "союзников"
word2 = "3"
encryptedWord1 = "KLCJKPDAJFFHEMIJOHJCBODINPKCBAIIMJFMEBDBMDMPLHBMMBBJDBABMDMKDMBE"
encryptedWord2 = "MKGADBKBMFMKKABFMGBMJBNBMAMGAMBC"
encryptedText = "NOFEJKGFCGHGCNABFNAFOAKDABDMDNGKCEEAFHAADGNBFMHOMHJAJOKINMOEDACFOKHCEAKFACHOODIBIMIBBCBOMFNEHKEJDAAIEIIAOKAFCNHJCHAHHNBEOOMEINHJAKJNOCKOMDNANAJFDBIFLICAKFAHLKDEFAFCECBGMCFHGHMPHIOGBAIJNDEDLOHOAMACIAKCNJMLNAJHOKGDJHJPHNDMHFOKAMEKAIPEOKMKPMJGHMAANAOJACFJFAFCFBPDFANAFFNHNDNOMCCBGJHAEBADNMEINEJNBPOEDNMOBAACAAGENOIHNKCABFAFHNOIDJCMAIFJHOHNACKAFCDIMIOBACABADPMIJEEAPMAIDADMAHCDCAOPJNHNDEDIOIGLAGAANNIGKEIOAFKGACCNEPILHIJOMIGIAIJAAAHGOICANAPNAAHNHIHKNAEKBHCENLHOLCICCIEDGIAEMPAFPAOGKHNKJCBCPLAJPFHCMIPOHJAFOAINFKENAIHANFEMMCAHPALFHAAMMFFBEJAMHACCHCKFEHMHIHAKDAFJIGBCMOPOOLNOLOCCOKPOLOMOPNIDBKNBEIAHEACLIEPKGDEIAHBBGIFHEBJMGAENKNHMMICGANAAMNHFOECMHHFJHGICBOAHDEMNCODKJHCACMLMNAFOAOEDKCJCPEDLNINNAAFMJNDAADAKAAAOPPHCEOCIKMIBDIEODOCEKOACDAGFNIHALIHJCBHCCCHGOAFAMABDCIOPAOFENJBMFALDODINBOJIFCDAHKMHFCIHPKLHCAMMJEICOIGNNNHCICDBFAMLIOPKPJHAAMKANAFMICEKNMMMFJBHJAEIEGHMMCHGAFHKMKONFDJHFABMCIPMCIJPANOADNAKKEFDHIGIAOJNGAPBKHNKLNDFFHAHGNIMOIHONJDPELAMPAODAIFFDKFGPMIDBKNFKMMAIACNEOAMDAHBAJCKMGMOPKNDKFKOFIGKMOCIAMIAAKBKNIPMHKHCCHHMDHECKECNGIBEIAEKLMDDKOIKHJCMAOCAFMHEAIMKPPOENGIBAOLBDIJEKFGLEGEMCIKNHODECCFJAPGAMFEGMBLBCBNKEHPMMDFIENDIGICNANIACKDEKEAMIKPFGCAFFNOLKCOKAJKCFBOHGNLEAIKILIAEJCAEIAHKKEMACINFIMAKMAHHKJHNCICDAKANFFLHKOFDNAIBIJCKCMEPNPFAJNNAFJAHPAMIFAFNAHPDCAGMJFKKCABCGECOBLJEFAGDMHIKGJFOCIGMHFKMAIANDIJEALHAHFLMOGCMKEBKHPIDKKKHMCFCGGICBNAEMAONFHFNBJCCAIGAIFEFAABAOIMHCIGKGFGOKAOANIEOOKANAANBKACANGAGBMJEJAANAAONOFNOHHBCAEABHAIAHAIMAJCNMMLAAJHOBGFLHJPHEDIDFOHAPEKIIFEOJMACMJBACALKEHHMJDKMAJPMHCOOFBAHHAKNPENFDKABPLIDBKAJKMAKIAJPCNGMCFFFAIFALABJIEFKNHKPNJFMIPFHJPIAAKFMDECAOJBAHEIHCKCGEAMKEPCBNNEBBMBKDIBOCJKEENJMCEECAICNHAFHIAGKDFLCAOBCEIEBIDEKBMAMKHBMOAICPHIDCKLDACCOENCGPKIDHKCOBIKFOCFKAJJAFABEMNJAOACBFICHEMDBNAIDPEBPAHAANFNIMHBHJANOAINNMOBONHAKPJMLHOADHACJAIGCMCBJIEJKOAIICHHMOGEOJBAECAMHFENMLIFCIIKKHKGCKCKAHEEOJIIAAKAEMJAHDAIGANPAHGJCAFHODHCLEIJMPAPNCNANOJMCKCACOABDAAEAOIIGJEPFIDBFOAIFONDHAKCNCMGJFAPEJEOFAPNAHOJGMJMEHPIMAPCACMABDBFJMIJMAAJFIADAKPKCFMMBACFAGHBKFKCIEILCCEOMBNNKKEGKJAHHCPGMHFCEAICHBAGGAJPNFDGMNFGMDIIBNJAFNAAFKCEEIGOBNOEBFMGCFBBFPPCMHIGDPNEODMGHPAPAGOANLADMADMINJAOAFEFNMKEFEPCIJDFAAONMOBCAKBCEHNKAOFAMHHCIHPANMGGOGNOGBLBFJCMMNNKJJAACADBOEFFHKKMPDADOAEMKMCKPIJEHIACMNFLKKAOJGHCGHNFDFGNFIDEBCEFAKFAAHEDMBHOPACEAJONEEDDAEJAAIALDLGDPFAKOJFAJIDLAACAJMDNKJPHMAAHHCICCKNMAHNFPCIHKLIKCKGHMNMAFEHGCFHMNCKEIAKKDIPPJNIAHKKGKCBAAABOAPHNMHJJAJLNMHPFFCIHDOPLCACFPGFKAOFADHJFFNHNLAIEAEHNMHHAAFGOAAHBJIOACOKCNNCAGPKKJGFBBHCKJADKPHBCHIOHBOOOCIPOHAAOIBHKNHFCANCDOIBBJMIAHODPKPNMIGNGPNNDKFFOFEKFIJBKEBAMMAEAAMKOGCHBPJMDGFMCMIAAJGBGKJNOJOHINAPNNJFHOGINLKCEAANHDAOEEFHMJCDOAHCKKEKEHBICNKKOMKCNACCMAMANCALKMOAMLJMECIOMCNGGAEJDJIJDNOOFONEPKPECFICFAFCAPMNOOKEMGINNNPIONOIHKECMGJDGJCIAKOAFAEKALEHHKDMKEFIDIAGNAPLAAGIAHKDFDANMBKHDEIADKNKEKEMNJJJPAIGAIFBCAAIDEICBNMOFHNKJKPKAPIMJFAAHMACLKAGMIGGICDEKBMMDFEBOIJCCENAMBAKGAIKDCKKFINNOBBMGKPIINAAJOLIEHOHPNEPAEKGENFFOHHLMCAACFOBAAHHAKDKFOKCMFECGBCCEHPJPMCAHCENOGJANBAJIMFIMNPDDNANBNOIDBEGAHOMCGMEFIMBBOADADHAEPAHGECOCDAMMLNNOJEJAGANJOEJNLCNKADBNIEMHMOGKJAPAHDEHDMPIAIANPHGBCEIPKOIDCAEAOBGIFLEHMMHHEAADKHNAADKNPCLBCHLNJGAEAMHAHHMCFAMNIIJHAKANMFHBKOBDMAOBADJNIEDINPCKLALCGOIFNKIIACDAPAHCEEHMPDJAAJDPBEFJOOANDNKAMCIAMBIMAAHNHCDJEANOCHHFBBAEKACMDIKDEELDEOAMOAEOMEAKNIEMEHJMGAENKCBAJNLACJIMNONHFAHFAPBEJGAAPNOIDNBODAKMAMNALOKGAIDDAANBNPJFMAHBNPLIOEPCOFIECOKCMEJABEPMNOEOGMPJMAEMPEJAGGFFCHIHICEEBIABADAACFKDOBFHMAENALNNNONMNHGFIJJLKBACPAAEAMGKECHPPFAJCFGDMIFOEJCBONINBKMEAIOAPFCFHLIHPKDHHAMCBGEGELKMCKIJFHNJMOJMGGAFOAFGOPEAIANKADCNHKKHFJMFIIOBEHPMFDIMOGLAINKKMBKFPCPAFJNBOAPDEFHMKCIEANCHMGNKGHANMAHDFFBNHHGLCFGMBFPNFAIHGOKAPHEDPMCPOHEOIJHMEEAMFANDAICMIJNFHMCDJPKHAEKHBELCAMFAOHBBMFNFJAAEPBNDMFOOAJPNHAMCCBEMFMIEFAMHFAIGMNAFEFFOAFNNFFNHPIIDGKEBHACNLAFCHGACDNHEAOJAMEDGENEMHMLKIJEKPAHFEBCMFMNHAKAKFHPDOKINJKHJHIHMKEEJGOFFPHEPICOAKIOEONAOFAKBKAJKHCCNPDAJPFFAMIMKMJBMDJIDHKBFAIHNHAIGIHHKJDHHAOHAOABNNPIOCKNDNJANAFADJCIADOCLHAFECBDGALIABKKCEJFOENEMNAAONNBCBIJELFBIECDMPDEIHOHADIFCOBNOJOLAKAJCCAEOMBAFNAGCNHIODDCKGAPFMDPCDIHCBEMHIOFKPHMAMHNMICMLFHAHHAPHPEOADILCJPAAONIBOAMOFAMLHEOCDOLCANEODDCIKOACEAPJDIJNGJOBHDHHBCHIAAFHGANBPBEDFMLHNFFOMJAOBCKEACLBAIGAEGPACOIFDOHJNAIHIAFAILGKJFLPAFGFBABOOOGOFFLFAGOMCAHPGKIFPKECACMFOIFCAKGACAEBOGBACGENGEAAJAOBAGDKKOCAJEGADFJBNICKEHHBPCNDHFGPCIMNCJCCBJAEDAFBAAFCACNAAEANAFAJCHAEHAGMACCADKPKNJHKPGPAKAMKOFINFIGHIABAIOGKOFIAAHMDHIHKODAONAOAKHCFGCBKIEAKIADDKGCKDFJEGBHFJMLCHIHBMAMCFBIHHKBAAMBDEIJOAEIACKEDOHJNBHOFCIEMLMDLHAGODJMJEIHMJDONAIHDDAFKPEADPNFJADEAIFJOINOKCNCCHJCDEIALAJJNCAIIKHIONNEFPHEJADJJOOFIKIPHADCACMMEOECJGIPEACJFAALPKPHDOMPMIAAOBACBFHAKLFONEMCIIMMJHIMNCOCHHEIDEOOONAHHBAAPIFNKKOINAHBDKENOIHPOADJMMPFEKCPCAHCAOMKCMBJHKAJEHLECCMNGAHJFDHBMEEHMLCDODNIDJDKLILJONAOHLHFMKIJMGDHFKCLLOCCDFIMOALEABOBJKHHDEEMHILOOMNDMMPIKJIEBHCICLOABKKENJGABJKIAAOPFFAPAPIKEHHGAANODOAMJKAADEKHMCCDJALCONCFCPGPDFDBKKICDMEOFJMAEDAPBMHKNHJBDAIFANHNNAABFGCDAHHECBMPPMGCMHCHBAFCAJMAHKEFNBADPIEGKPFLCAOMCNIFJMOHFMDJEKHAHBAHCHEICCOFKAHIOICHBGHCFHMFJMOKHJGGNIAFKKHCCFFIDBAAPIJAOPAFDNPENDGPFOJNNHBLEFALAOEEOFOGCHNBCMABOJANMEPAMEAGJANAKPIGBPBPDDDJBCIDAANJDIMAOFAIPFAJNEHPFANPAKBCPNGJALIAHGDDFHDLBKJJDOILDEJHMJCEMKHFNFIPCAIIAMCCLOGAABEBDECHMBCELMJGDGABIAEDAEHDINPGACGGEJAEFAIGJNABMFAMOJIKAMCOLFEOOGACHHCHIICEFNOGOIAKKABEAJMKGAICKKDDDAKOAIEGHDIONEGBMKFJKIEJNFABNKACDAKONHNMFAOFHLAGECMHMDHEPAFFDDIEFIIJOBANGKHLDIADEAMHAMACHNPCAMGBELGEJBMODNAEKGHPDIFPOFDBNCCEFJPJDJLAEJAPHDNBBMELIAGNNABONBNCNHNNMPCIDEOMFOAFOCAMCAEJFJAOPAOFFAABCNFJFOEIONGKDIANBIKDKJDHFAHBFHOFEAOPACDMCOGJAAILDHGOCOOEEOAAMKCGIOKINJOMLMCJAAEPMCHGKMFHCMANLEIADPHIDDOHAKDPKKKJHAICAHMJBKIJMCNCGPKADINCOOEFFJGHJAGCAFMCGFNDAJICFCOFMHHCEKAFMEIPLEMAIMAOIKEMFECGBIMHKOCNBMGAACILKMGJFCEEGKJKKOADLGLIFFKAMACFFPKOOABIAIKHMKMJDGKMEEBDMFDAAKPHOBCDDGNNFBFHKKIIAKAEBAMNNABBFAJLDFICMJOAEBACJOHKKDOCHGMIFJKEJNIDKFHDKHOODMOCJCIEDFAHKMHAFFAGAAHPKGHJENKFOPHADHINCEEFJDMPDPDOKMHKMGICENBAFOANMOCKNBJKEAHAAFFMPAAEHKAHGAENNHOHCNHKNHECFAJEADOJCMGAMMCBIADOAKOGPMEBOKCALPLIDJOAMMIOALBBJIPCKNCBAEAGPNIMHEEHMFCJOOCGHLILIANCANMIEKFJEOFOFALIFCONAHBMHDAJKAKPACBEKAFAMBIANOLFNOHEKKCFAJECEHOIHJKECMADODPKCCMIKDOLNDODFPGJOANIAKKIFFNMHEGGLENGMCFMPFFFOEAEPAIHAFCKMAOCMOOCFCNOMNNANOCOCOIIHAMOAGNNEOKNDDIFIPMEDEMJBKPEABDBCGKEFCMKLDAOHKHOEECPMFDOMCHLAEICHJNEAMMENOAKOHOBHAICNGKPLONFBOOBBGBBNPMPIOGEMABGMBBBMMMPHMBJ"

# Генерация словаря замены на основе позиций символов, шифруемого слова и шифра для этого слова
def getReplaceTable(setOfPositions, word: str, encryption: str):
    # Словарь состоящий из (Пара шифрующих символов - Шифруемая буква)
    replaceTable = {}
    word = list(word)
    encryption = list(encryption)
    # Нет ли пары, которая указывает на 2 буквы одновременно
    hasAnyMatches = False
    # Добиваем слово пустышками
    while len(word) < 8: word += "*"
    # Количество сетов шифрующих символов
    setsCount = 2
    if len(word) > 8:
        # Т.к. "союзников" состоит из двух блоков, добиваем его пустышками тоже
        while len(word) < 16: word += "*"
        setsCount = 4
    for i in range(setsCount):
        for j in range(0, 8, 2):
            symbolsPair = encryption[int(setOfPositions[j]) + i * 16] + encryption[int(setOfPositions[j + 1]) + i * 16]
            # Если 2 пары символов указывают на одну букву в слове, то запоминаем это
            if symbolsPair in replaceTable and replaceTable[symbolsPair] != word[(j // 2) + i * 4]:
                hasAnyMatches = True
            replaceTable[symbolsPair] = word[(j // 2) + i * 4]
    return [replaceTable, hasAnyMatches]


# Возвращает длину самого длинного слова в тексте
def getTheLongestWord(text):
    words = text.split()
    maxLength = 0
    # Сравнение длинн слов
    for word in words:
        if len(word) > maxLength:
            maxLength = len(word)
    return maxLength


# Проверка, стоят ли пустые символы только в конце строки
def checkIfEmptySymbolsInTheEndOnly(text):
    # Удаляем все пустые символы справа и ищем их в тексте
    if text.rstrip("*").find("*") >= 0:
        return False
    return True

# Возвращает массив из всех альтернатив расшифрованного текста (на основе переданных индексов)
def findDecryptionVariants(indexes, encryptedTextDividedByBlocks):
    variants = []
    # Все варианты перестановок переданных индексов
    indexesPermutations = itertools.permutations(indexes)
    # Текущая комбинация
    for permutation in indexesPermutations:
        repetitionRates = {}
        newDecryptedText = ""
        [replaceTable1, hasAnyMatches1] = getReplaceTable(permutation, word1, encryptedWord1)
        [replaceTable2, hasAnyMatches2] = getReplaceTable(permutation, word2, encryptedWord2)
        hasAnyMatchesBetweenTables = False
        # Проверяем, не указывает ли 1 пара на 2 разных символа между "союзников" и "3"
        for symbolsPair in replaceTable1:
            if symbolsPair in replaceTable2 and replaceTable1[symbolsPair] != replaceTable2[symbolsPair]:
                hasAnyMatchesBetweenTables = True
        if not hasAnyMatches1 and not hasAnyMatches2 and not hasAnyMatchesBetweenTables:
            for i in range(len(encryptedTextDividedByBlocks)):
                # Расшифрованные 4 символа из текста
                decrypted4Symbols = ["?" for x in range(4)]
                for j in range(0, 8, 2):
                    # Текущая пара символов
                    symbolsPair = encryptedTextDividedByBlocks[i][int(permutation[j])] + \
                                  encryptedTextDividedByBlocks[i][int(permutation[j + 1])]
                    # Записываем частоты символов
                    if symbolsPair in repetitionRates:
                        repetitionRates[symbolsPair] += 1
                    else:
                        repetitionRates[symbolsPair] = 1
                    # Готовые расшифрованные пары из "союзников" сразу вставляем в текст
                    if symbolsPair in replaceTable1:
                        decrypted4Symbols[j // 2] = replaceTable1[symbolsPair]
                #  Записываем новые 4 символа в итоговую версию
                newDecryptedText += "".join(decrypted4Symbols)

            #  Сортируем словарь по убыванию частот
            repetitionRates = dict(sorted(repetitionRates.items(), key=lambda item: item[1], reverse=True))
            newDecryptionVariantText = list(newDecryptedText)
            for i in range(len(encryptedTextDividedByBlocks)):
                for j in range(0, 8, 2):
                    symbolsPair = encryptedTextDividedByBlocks[i][int(permutation[j])] + \
                                  encryptedTextDividedByBlocks[i][int(permutation[j + 1])]
                    # Самую частую пару считаем пробелом
                    if symbolsPair == list(repetitionRates)[0]:
                        newDecryptionVariantText[i*4 + j//2] = " "
            newObjectInResult = {}
            newDecryptedText = "".join(newDecryptionVariantText)
            # Полученный вариант расшифровки складываем в словарь
            newObjectInResult["decryptedText"] = newDecryptedText
            # В словарь соответствий "союзников" добавляем еще пробел (самую частую пару)
            replaceTable1.update({list(repetitionRates)[0]: " "})
            newObjectInResult["replaceTable"] = replaceTable1
            newObjectInResult["symbolsPairsCombo"] = permutation
            theLongestWordLen = getTheLongestWord(newDecryptedText)
            # Проверка на корректность варианта
            if theLongestWordLen <= 35 and \
                    checkIfEmptySymbolsInTheEndOnly(newDecryptedText):
                variants.append(newObjectInResult)
    return variants


# Дробление строки на подстроки по n символов
def divideStroke(text, n):
    return [text[i:i + n] for i in range(0, len(text), n)]


def decrypt():
    # Составляем пары только из значащих символов
    clearedText = ""
    for i in range(0, len(encryptedText), 16):
        clearedText += encryptedText[i + 2] + encryptedText[i + 13] + \
                       encryptedText[i + 14] + encryptedText[i] + \
                       encryptedText[i + 5] + encryptedText[i + 8] + \
                       encryptedText[i + 7] + encryptedText[i + 10]

    # Разграничиваем каждую пару символов
    originalText = ' '.join(clearedText[i:i + 2] for i in range(0, len(clearedText), 2))

    # Заменяем пары символов на символы согласно таблице
    originalText = originalText.replace("BM", "*")
    originalText = originalText.replace("AA", "_")
    originalText = originalText.replace("CM", "с")
    originalText = originalText.replace("IK", "о")
    originalText = originalText.replace("PJ", "ю")
    originalText = originalText.replace("AF", "з")
    originalText = originalText.replace("JA", "н")
    originalText = originalText.replace("IO", "и")
    originalText = originalText.replace("ON", "к")
    originalText = originalText.replace("KI", "о")
    originalText = originalText.replace("FH", "в")
    originalText = originalText.replace("GA", "3")
    originalText = originalText.replace("FG", "т")
    originalText = originalText.replace("AN", "а")
    originalText = originalText.replace("BE", "я")
    originalText = originalText.replace("CH", "р")
    originalText = originalText.replace("DP", "л")
    originalText = originalText.replace("EM", "е")
    originalText = originalText.replace("CK", "ч")
    originalText = originalText.replace("FM", "ц")
    originalText = originalText.replace("GF", "т")
    originalText = originalText.replace("HC", "р")
    originalText = originalText.replace("HF", "Н")
    originalText = originalText.replace("HH", "п")
    originalText = originalText.replace("KC", "х")
    originalText = originalText.replace("KK", "б")
    originalText = originalText.replace("MB", "С")
    originalText = originalText.replace("MC", "с")
    originalText = originalText.replace("ME", "е")
    originalText = originalText.replace("MF", "ы")
    originalText = originalText.replace("NA", "а")
    originalText = originalText.replace("NO", "д")
    originalText = originalText.replace("OI", "и")
    originalText = originalText.replace("OO", "у")
    originalText = originalText.replace("OE", "ш")
    originalText = originalText.replace("PE", "л")
    originalText = originalText.replace("DD", "г")
    originalText = originalText.replace("CP", "ц")
    originalText = originalText.replace("EI", "й")
    originalText = originalText.replace("HD", "м")
    originalText = originalText.replace("HN", "Б")
    originalText = originalText.replace("JE", ",")
    originalText = originalText.replace("NB", "ж")
    originalText = originalText.replace("FN", "З")
    originalText = originalText.replace("GN", ".")
    originalText = originalText.replace("FC", "Ш")
    originalText = originalText.replace("PD", "л")
    originalText = originalText.replace("NF", "ь")
    originalText = originalText.replace("HI", "э")
    originalText = originalText.replace("CC", "ф")
    originalText = originalText.replace("EO", "В")
    originalText = originalText.replace("CF", "(")
    originalText = originalText.replace("MH", "–")
    originalText = originalText.replace("PB", "М")
    originalText = originalText.replace("DL", "-")
    originalText = originalText.replace("LA", "П")
    originalText = originalText.replace("KO", "О")
    originalText = originalText.replace("ED", "щ")
    originalText = originalText.replace("JD", "Р")
    originalText = originalText.replace("IC", "Г")
    originalText = originalText.replace("LJ", "Ч")
    originalText = originalText.replace("JF", "Э")
    originalText = originalText.replace("PG", "А")
    originalText = originalText.replace("JB", "Е")
    originalText = originalText.replace("DH", "Д")
    originalText = originalText.replace("HA", "У")
    originalText = originalText.replace("EB", "«")
    originalText = originalText.replace("GB", "»")
    originalText = originalText.replace("HM", ")")

    # Убираем все пробелы
    originalText = originalText.replace(" ", "")
    # Заменяем _ на пробелы
    originalText = originalText.replace("_", " ")
    return originalText


if __name__ == "__main__":
    # Индексы шифрующих символов
    symbolsIndexesToCheck = [2, 13, 14, 0, 5, 8, 7, 10]
    # Дробим зашифрованный текст на блоки по 16 символов
    decryptedTextDividedToBlocks = divideStroke(encryptedText, 16)
    print("Расшифрованный текст:")
    print(decrypt())
    # Перебираем все варианты расшифровки
    result = findDecryptionVariants(symbolsIndexesToCheck, decryptedTextDividedToBlocks)
    for decryptionDict in result:
        for key, value in decryptionDict.items():
            print('%s: %s\n' % (key, value))
        print("------------")

    print("Всего вариантов = " + str(len(result)))


