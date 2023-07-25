public class infNFe
{
    public string versao { get; set; } = "";
}
public class Identificacao
{
    public string cNF { get; set; } = "";
    public string natOp { get; set; } = "";
    public string indPag { get; set; } = "";
    public string mod { get; set; } = "";
    public string serie { get; set; } = "";
    public string nNF { get; set; } = "";
    public string dhEmi { get; set; } = "";
    public string dhSaiEnt { get; set; } = "";
    public string tpNF { get; set; } = "";
    public string idDest { get; set; } = "";
    public string tpAmb { get; set; } = "";
    public string tpImp { get; set; } = "";
    public string tpEmis { get; set; } = "";
    public string finNFe { get; set; } = "";
    public string indFinal { get; set; } = "";
    public string indPres { get; set; } = "";
    public string procEmi { get; set; } = "";
    public string cMunFG { get; set; } = "";
    public string indIntermed { get; set; } = "";
    public string verProc { get; set; } = "";
    public string dhCont { get; set; } = "";
    public string xJust { get; set; } = "";
}
public class NFRef001
{
    public string Tipo { get; set; } = "";
    public string refNFe { get; set; } = "";
    public string cUF { get; set; } = "";
    public string AAMM { get; set; } = "";
    public string CNPJ { get; set; } = "";
    public string mod { get; set; } = "";
    public string Serie { get; set; } = "";
    public string nNF { get; set; } = "";
    public string CNPJCPF { get; set; } = "";
    public string IE { get; set; } = "";
    public string refCTe { get; set; } = "";
    public string ModECF { get; set; } = "";
    public string nECF { get; set; } = "";
    public string nCOO { get; set; } = "";
}
public class Emitente
{
    public string CRT { get; set; } = "";
    public string CNPJCPF { get; set; } = "";
    public string xNome { get; set; } = "";
    public string xFant { get; set; } = "";
    public string IE { get; set; } = "";
    public string IEST { get; set; } = "";
    public string IM { get; set; } = "";
    public string CNAE { get; set; } = "";
    public string xLgr { get; set; } = "";
    public string nro { get; set; } = "";
    public string xCpl { get; set; } = "";
    public string xBairro { get; set; } = "";
    public string cMun { get; set; } = "";
    public string xMun { get; set; } = "";
    public string cUF { get; set; } = "";
    public string UF { get; set; } = "";
    public string CEP { get; set; } = "";
    public string cPais { get; set; } = "";
    public string xPais { get; set; } = "";
    public string Fone { get; set; } = "";
}
public class Avulsa
{
    public string CNPJ { get; set; } = "";
    public string xOrgao { get; set; } = "";
    public string matr { get; set; } = "";
    public string xAgente { get; set; } = "";
    public string fone { get; set; } = "";
    public string UF { get; set; } = "";
    public string nDAR { get; set; } = "";
    public string dEmi { get; set; } = "";
    public string vDAR { get; set; } = "";
    public string repEmi { get; set; } = "";
    public string dPag { get; set; } = "";
}
public class Destinatario
{
    public string idEstrangeiro { get; set; } = "";
    public string CNPJCPF { get; set; } = "";
    public string xNome { get; set; } = "";
    public string indIEDest { get; set; } = "";
    public string IE { get; set; } = "";
    public string ISUF { get; set; } = "";
    public string Email { get; set; } = "";
    public string xLgr { get; set; } = "";
    public string nro { get; set; } = "";
    public string xCpl { get; set; } = "";
    public string xBairro { get; set; } = "";
    public string cMun { get; set; } = "";
    public string xMun { get; set; } = "";
    public string UF { get; set; } = "";
    public string CEP { get; set; } = "";
    public string cPais { get; set; } = "";
    public string xPais { get; set; } = "";
    public string Fone { get; set; } = "";
}
public class Retirada
{
    public string CNPJCPF { get; set; } = "";
    public string xNome { get; set; } = "";
    public string xLgr { get; set; } = "";
    public string nro { get; set; } = "";
    public string xCpl { get; set; } = "";
    public string xBairro { get; set; } = "";
    public string cMun { get; set; } = "";
    public string xMun { get; set; } = "";
    public string UF { get; set; } = "";
    public string CEP { get; set; } = "";
    public string PaisCod { get; set; } = "";
    public string Pais { get; set; } = "";
    public string Fone { get; set; } = "";
    public string Email { get; set; } = "";
    public string IE { get; set; } = "";
}
public class Entrega
{
    public string CNPJCPF { get; set; } = "";
    public string xNome { get; set; } = "";
    public string xLgr { get; set; } = "";
    public string nro { get; set; } = "";
    public string xCpl { get; set; } = "";
    public string xBairro { get; set; } = "";
    public string cMun { get; set; } = "";
    public string xMun { get; set; } = "";
    public string UF { get; set; } = "";
    public string CEP { get; set; } = "";
    public string PaisCod { get; set; } = "";
    public string Pais { get; set; } = "";
    public string Fone { get; set; } = "";
    public string Email { get; set; } = "";
    public string IE { get; set; } = "";
}
public class autXML01
{
    public string CNPJCPF { get; set; } = "";
}
public class Produto001
{
    public string cProd { get; set; } = "";
    public string cEAN { get; set; } = "";
    public string cEANTrib { get; set; } = "";
    public string cBarra { get; set; } = "";
    public string xProd { get; set; } = "";
    public string NCM { get; set; } = "";
    public string CEST { get; set; } = "";
    public string EXTIPI { get; set; } = "";
    public string CFOP { get; set; } = "";
    public string uCom { get; set; } = "";
    public string qCom { get; set; } = "";
    public string vUnCom { get; set; } = "";
    public string vProd { get; set; } = "";
    public string cBarraTrib { get; set; } = "";
    public string uTrib { get; set; } = "";
    public string qTrib { get; set; } = "";
    public string vUnTrib { get; set; } = "";
    public string vFrete { get; set; } = "";
    public string vSeg { get; set; } = "";
    public string vDesc { get; set; } = "";
    public string vOutro { get; set; } = "";
    public string indTot { get; set; } = "";
    public string xPed { get; set; } = "";
    public string nItemPed { get; set; } = "";
    public string nFCI { get; set; } = "";
    public string nRECOPI { get; set; } = "";
    public string pDevol { get; set; } = "";
    public string vIPIDevol { get; set; } = "";
    public string vTotTrib { get; set; } = "";
    public string infAdProd { get; set; } = "";
    public string indEscala { get; set; } = "";
    public string CNPJFab { get; set; } = "";
    public string cBenef { get; set; } = "";
}
public class NVE001001
{
    public string NVE { get; set; } = "";
}
public class DI001001
{
    public string nDi { get; set; } = "";
    public string dDi { get; set; } = "";
    public string xLocDesemb { get; set; } = "";
    public string UFDesemb { get; set; } = "";
    public string dDesemb { get; set; } = "";
    public string tpViaTransp { get; set; } = "";
    public string vAFRMM { get; set; } = "";
    public string tpIntermedio { get; set; } = "";
    public string CNPJ { get; set; } = "";
    public string UFTerceiro { get; set; } = "";
    public string cExportador { get; set; } = "";
}
public class LADI001001001
{
    public string nAdicao { get; set; } = "";
    public string nSeqAdi { get; set; } = "";
    public string cFabricante { get; set; } = "";
    public string vDescDI { get; set; } = "";
    public string nDraw { get; set; } = "";
}
public class detExport001001
{
    public string nDraw { get; set; } = "";
    public string nRE { get; set; } = "";
    public string chNFe { get; set; } = "";
    public string qExport { get; set; } = "";
}
public class rastro001001
{
    public string nLote { get; set; } = "";
    public string qLote { get; set; } = "";
    public string dFab { get; set; } = "";
    public string dVal { get; set; } = "";
    public string cAgreg { get; set; } = "";
}
public class Medicamento001001
{
    public string cProdANVISA { get; set; } = "";
    public string vPMC { get; set; } = "";
    public string nLote { get; set; } = "";
    public string qLote { get; set; } = "";
    public string dFab { get; set; } = "";
    public string dVal { get; set; } = "";
}
public class Arma001001
{
    public string nSerie { get; set; } = "";
    public string tpArma { get; set; } = "";
    public string nCano { get; set; } = "";
    public string descr { get; set; } = "";
}
public class impostoDevol001
{
    public string pDevol { get; set; } = "";
    public string vIPIDevol { get; set; } = "";
}
public class Veiculo001
{
    public string chassi { get; set; } = "";
    public string tpOP { get; set; } = "";
    public string cCor { get; set; } = "";
    public string xCor { get; set; } = "";
    public string pot { get; set; } = "";
    public string Cilin { get; set; } = "";
    public string pesoL { get; set; } = "";
    public string pesoB { get; set; } = "";
    public string nSerie { get; set; } = "";
    public string tpComb { get; set; } = "";
    public string nMotor { get; set; } = "";
    public string CMT { get; set; } = "";
    public string dist { get; set; } = "";
    public string anoMod { get; set; } = "";
    public string anoFab { get; set; } = "";
    public string tpPint { get; set; } = "";
    public string tpVeic { get; set; } = "";
    public string espVeic { get; set; } = "";
    public string VIN { get; set; } = "";
    public string condVeic { get; set; } = "";
    public string cMod { get; set; } = "";
    public string cCorDENATRAN { get; set; } = "";
    public string lota { get; set; } = "";
    public string tpRest { get; set; } = "";
}
public class Combustivel001
{
    public string cProdANP { get; set; } = "";
    public string pMixGN { get; set; } = "";
    public string CODIF { get; set; } = "";
    public string qTemp { get; set; } = "";
    public string UFCons { get; set; } = "";
    public string descANP { get; set; } = "";
    public string pGLP { get; set; } = "";
    public string pGNn { get; set; } = "";
    public string pGNi { get; set; } = "";
    public string vPart { get; set; } = "";
}
public class CIDE001
{
    public string qBCprod { get; set; } = "";
    public string vAliqProd { get; set; } = "";
    public string vCIDE { get; set; } = "";
}
public class ICMSComb001
{
    public string vBCICMS { get; set; } = "";
    public string vICMS { get; set; } = "";
    public string vBCICMSST { get; set; } = "";
    public string vICMSST { get; set; } = "";
}
public class ICMSInter001
{
    public string vBCICMSSTDest { get; set; } = "";
    public string vICMSSTDest { get; set; } = "";
}
public class ICMSCons001
{
    public string vBCICMSSTCons { get; set; } = "";
    public string vICMSSTCons { get; set; } = "";
    public string UFCons { get; set; } = "";
}
public class ICMS001
{
    public string CSOSN { get; set; } = "";
    public string orig { get; set; } = "";
    public string CST { get; set; } = "";
    public string modBC { get; set; } = "";
    public string pRedBC { get; set; } = "";
    public string vBC { get; set; } = "";
    public string pICMS { get; set; } = "";
    public string vICMS { get; set; } = "";
    public string modBCST { get; set; } = "";
    public string pMVAST { get; set; } = "";
    public string pRedBCST { get; set; } = "";
    public string vBCST { get; set; } = "";
    public string pICMSST { get; set; } = "";
    public string vICMSST { get; set; } = "";
    public string UFST { get; set; } = "";
    public string pBCOp { get; set; } = "";
    public string vBCSTRet { get; set; } = "";
    public string vICMSSTRet { get; set; } = "";
    public string motDesICMS { get; set; } = "";
    public string pCredSN { get; set; } = "";
    public string vCredICMSSN { get; set; } = "";
    public string vBCSTDest { get; set; } = "";
    public string vICMSSTDest { get; set; } = "";
    public string vICMSDeson { get; set; } = "";
    public string vICMSOp { get; set; } = "";
    public string pDif { get; set; } = "";
    public string vICMSDif { get; set; } = "";
    public string pST { get; set; } = "";
    public string vBCFCP { get; set; } = "";
    public string pFCP { get; set; } = "";
    public string vFCP { get; set; } = "";
    public string vBCFCPST { get; set; } = "";
    public string pFCPST { get; set; } = "";
    public string vFCPST { get; set; } = "";
    public string vBCFCPSTRet { get; set; } = "";
    public string pFCPSTRet { get; set; } = "";
    public string vFCPSTRet { get; set; } = "";
    public string pRedBCEfet { get; set; } = "";
    public string vBCEfet { get; set; } = "";
    public string pICMSEfet { get; set; } = "";
    public string vICMSEfet { get; set; } = "";
    public string vICMSSubstituto { get; set; } = "";
    public string vICMSSTDeson { get; set; } = "";
    public string motDesICMSST { get; set; } = "";
    public string pFCPDif { get; set; } = "";
    public string vFCPDif { get; set; } = "";
    public string vFCPEfet { get; set; } = "";
}
public class ICMSUFDEST001
{
    public string vBCUFDest { get; set; } = "";
    public string vBCFCPUFDest { get; set; } = "";
    public string pFCPUFDest { get; set; } = "";
    public string pICMSUFDest { get; set; } = "";
    public string pICMSInter { get; set; } = "";
    public string pICMSInterPart { get; set; } = "";
    public string vFCPUFDest { get; set; } = "";
    public string vICMSUFDest { get; set; } = "";
    public string vICMSUFRemet { get; set; } = "";
}
public class IPI001
{
    public string CST { get; set; } = "";
    public string clEnq { get; set; } = "";
    public string CNPJProd { get; set; } = "";
    public string cSelo { get; set; } = "";
    public string qSelo { get; set; } = "";
    public string cEnq { get; set; } = "";
    public string vBC { get; set; } = "";
    public string qUnid { get; set; } = "";
    public string vUnid { get; set; } = "";
    public string pIPI { get; set; } = "";
    public string vIPI { get; set; } = "";
}
public class II001
{
    public string vBC { get; set; } = "";
    public string vDespAdu { get; set; } = "";
    public string vII { get; set; } = "";
    public string vIOF { get; set; } = "";
}
public class PIS001
{
    public string CST { get; set; } = "";
    public string vBC { get; set; } = "";
    public string pPIS { get; set; } = "";
    public string qBCProd { get; set; } = "";
    public string vAliqProd { get; set; } = "";
    public string vPIS { get; set; } = "";
}
public class PISST001
{
    public string vBC { get; set; } = "";
    public string pPis { get; set; } = "";
    public string qBCProd { get; set; } = "";
    public string vAliqProd { get; set; } = "";
    public string vPIS { get; set; } = "";
    public string indSomaPISST { get; set; } = "";
}
public class COFINS001
{
    public string CST { get; set; } = "";
    public string vBC { get; set; } = "";
    public string pCOFINS { get; set; } = "";
    public string qBCProd { get; set; } = "";
    public string vAliqProd { get; set; } = "";
    public string vCOFINS { get; set; } = "";
}
public class COFINSST001
{
    public string vBC { get; set; } = "";
    public string pCOFINS { get; set; } = "";
    public string qBCProd { get; set; } = "";
    public string vAliqProd { get; set; } = "";
    public string vCOFINS { get; set; } = "";
    public string indSomaCOFINSST { get; set; } = "";
}
public class ISSQN001
{
    public string vBC { get; set; } = "";
    public string vAliq { get; set; } = "";
    public string vISSQN { get; set; } = "";
    public string cMunFG { get; set; } = "";
    public string cListServ { get; set; } = "";
    public string cSitTrib { get; set; } = "";
    public string vDeducao { get; set; } = "";
    public string vOutro { get; set; } = "";
    public string vDescIncond { get; set; } = "";
    public string vDescCond { get; set; } = "";
    public string vISSRet { get; set; } = "";
    public string indISS { get; set; } = "";
    public string cServico { get; set; } = "";
    public string cMun { get; set; } = "";
    public string cPais { get; set; } = "";
    public string nProcesso { get; set; } = "";
    public string indIncentivo { get; set; } = "";
}
public class obsContItem001
{
    public string xCampo { get; set; } = "";
    public string xTexto { get; set; } = "";
}
public class obsFiscoItem001
{
    public string xCampo { get; set; } = "";
    public string xTexto { get; set; } = "";
}
public class Total
{
    public string vBC { get; set; } = "";
    public string vICMS { get; set; } = "";
    public string vICMSDeson { get; set; } = "";
    public string vFCPUFDest { get; set; } = "";
    public string vICMSUFDest { get; set; } = "";
    public string vICMSUFRemet { get; set; } = "";
    public string vBCST { get; set; } = "";
    public string vST { get; set; } = "";
    public string vProd { get; set; } = "";
    public string vFrete { get; set; } = "";
    public string vSeg { get; set; } = "";
    public string vDesc { get; set; } = "";
    public string vII { get; set; } = "";
    public string vIPI { get; set; } = "";
    public string vPIS { get; set; } = "";
    public string vCOFINS { get; set; } = "";
    public string vOutro { get; set; } = "";
    public string vNF { get; set; } = "";
    public string vTotTrib { get; set; } = "";
    public string vFCP { get; set; } = "";
    public string vFCPST { get; set; } = "";
    public string vFCPSTRet { get; set; } = "";
    public string vIPIDevol { get; set; } = "";
}
public class ISSQNtot
{
    public string vServ { get; set; } = "";
    public string vBC { get; set; } = "";
    public string vISS { get; set; } = "";
    public string vPIS { get; set; } = "";
    public string vCOFINS { get; set; } = "";
    public string dCompet { get; set; } = "";
    public string vDeducao { get; set; } = "";
    public string vOutro { get; set; } = "";
    public string vDescIncond { get; set; } = "";
    public string vDescCond { get; set; } = "";
    public string vISSRet { get; set; } = "";
    public string cRegTrib { get; set; } = "";
}
public class retTrib
{
    public string vRetPIS { get; set; } = "";
    public string vRetCOFINS { get; set; } = "";
    public string vRetCSLL { get; set; } = "";
    public string vBCIRRF { get; set; } = "";
    public string vIRRF { get; set; } = "";
    public string vBCRetPrev { get; set; } = "";
    public string vRetPrev { get; set; } = "";
}
public class Transportador
{
    public string modFrete { get; set; } = "";
    public string CNPJCPF { get; set; } = "";
    public string xNome { get; set; } = "";
    public string IE { get; set; } = "";
    public string xEnder { get; set; } = "";
    public string xMun { get; set; } = "";
    public string UF { get; set; } = "";
    public string vServ { get; set; } = "";
    public string vBCRet { get; set; } = "";
    public string pICMSRet { get; set; } = "";
    public string vICMSRet { get; set; } = "";
    public string CFOP { get; set; } = "";
    public string cMunFG { get; set; } = "";
    public string Placa { get; set; } = "";
    public string UFPlaca { get; set; } = "";
    public string RNTC { get; set; } = "";
    public string vagao { get; set; } = "";
    public string balsa { get; set; } = "";
}
public class Reboque001
{
    public string placa { get; set; } = "";
    public string UF { get; set; } = "";
    public string RNTC { get; set; } = "";
}
public class Volume001
{
    public string qVol { get; set; } = "";
    public string esp { get; set; } = "";
    public string Marca { get; set; } = "";
    public string nVol { get; set; } = "";
    public string pesoL { get; set; } = "";
    public string pesoB { get; set; } = "";
}
public class Lacre001001
{
    public string nLacre { get; set; } = "";
}
public class Fatura
{
    public string nFat { get; set; } = "";
    public string vOrig { get; set; } = "";
    public string vDesc { get; set; } = "";
    public string vLiq { get; set; } = "";
}
public class Duplicata001
{
    public string nDup { get; set; } = "";
    public string dVenc { get; set; } = "";
    public string vDup { get; set; } = "";
}
public class pag001
{
    public string tPag { get; set; } = "";
    public string vPag { get; set; } = "";
    public string indPag { get; set; } = "";
    public string xPag { get; set; } = "";
}
public class pag002
{
    public string tPag { get; set; } = "";
    public string vPag { get; set; } = "";
    public string indPag { get; set; } = "";
    public string tpIntegra { get; set; } = "";
    public string CNPJ { get; set; } = "";
    public string tBand { get; set; } = "";
    public string cAut { get; set; } = "";
    public string vTroco { get; set; } = "";
}
public class infIntermed
{
    public string CNPJ { get; set; } = "";
    public string idCadIntTran { get; set; } = "";
}
public class DadosAdicionais
{
    public string infAdFisco { get; set; } = "";
    public string infCpl { get; set; } = "";
}
public class InfAdic001
{
    public string xCampo { get; set; } = "";
    public string xTexto { get; set; } = "";
}
public class ObsFisco001
{
    public string xCampo { get; set; } = "";
    public string xTexto { get; set; } = "";
}
public class procRef001
{
    public string nProc { get; set; } = "";
    public string indProc { get; set; } = "";
}
public class Exporta
{
    public string UFSaidaPais { get; set; } = "";
    public string xLocExporta { get; set; } = "";
    public string xLocDespacho { get; set; } = "";
}
public class Compra
{
    public string xNEmp { get; set; } = "";
    public string xPed { get; set; } = "";
    public string xCont { get; set; } = "";
}
public class cana
{
    public string safra { get; set; } = "";
    public string ref { get; set; } = "";
    public string qTotMes { get; set; } = "";
    public string qTotAnt { get; set; } = "";
    public string qTotGer { get; set; } = "";
    public string vFor { get; set; } = "";
    public string vTotDed { get; set; } = "";
    public string vLiqFor { get; set; } = "";
}
public class forDia001
{
    public string dia { get; set; } = "";
    public string qtde { get; set; } = "";
}
public class deduc001
{
    public string xDed { get; set; } = "";
    public string vDed { get; set; } = "";
}
public class infRespTec
{
    public string CNPJ { get; set; } = "";
    public string xContato { get; set; } = "";
    public string email { get; set; } = "";
    public string fone { get; set; } = "";
}
