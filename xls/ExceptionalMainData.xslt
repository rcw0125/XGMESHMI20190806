<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" indent="yes" encoding="gb2312"/>
  <xsl:template match="/">
    <xsl:element name ="ufinterface">
      <xsl:attribute name ="billtype">YCXX</xsl:attribute>
      <xsl:attribute name ="filename"></xsl:attribute>
      <xsl:attribute name ="isexchange">Y</xsl:attribute>
      <xsl:attribute name ="operation">req</xsl:attribute>
      <xsl:attribute name ="proc">add</xsl:attribute>
      <xsl:attribute name ="receiver">101</xsl:attribute>
      <xsl:attribute name ="replace">N</xsl:attribute>
      <xsl:attribute name ="roottag">bill</xsl:attribute>
      <xsl:attribute name ="sender">1104</xsl:attribute>

      <xsl:element name ="bill">
        <xsl:attribute name ="id">
          <xsl:value-of select ="NewDataSet/M/pch"/>
        </xsl:attribute>
        <xsl:element name ="bill_head">
          <xsl:element name ="ddzxVO">
            <xsl:element name ="rq">
              <xsl:value-of select="NewDataSet/M/CreateDate"/>
            </xsl:element>
            <xsl:element name ="gzzxid">
              <xsl:value-of select="NewDataSet/M/UnitID"/>
            </xsl:element>
            <xsl:element name ="bcid">
              <xsl:value-of select="NewDataSet/M/Shift"/>
            </xsl:element>
            <xsl:element name ="bzid">
              <xsl:value-of select="NewDataSet/M/Team"/>
            </xsl:element>
            <xsl:element name ="zbddyid">
              <xsl:value-of select="NewDataSet/M/Operator"/>
            </xsl:element>
            <xsl:element name ="lrsj">
              <xsl:value-of select="NewDataSet/M/CreateTime"/>
            </xsl:element>
          </xsl:element>
        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>