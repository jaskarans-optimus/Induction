<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
	<html>
	<body>
	<h2>Students</h2>
	<table border="1">
		<tr bgcolo="#9acd32">
			<th>Name</th>
			<th>Age</th>
			<th>Address</th>
		</tr>
    <xsl:for-each select="students/student">
      <xsl:if test="stream='PCM'">
      <tr>
        <td>
          <xsl:value-of select="@name" />
        </td>
        <td>
          <xsl:value-of select="@age" />
        </td>
        <td>
          <xsl:value-of select="address/city" />
        </td>
      </tr>
     </xsl:if>
    </xsl:for-each>
	</table>
	</body>
	</html>
</xsl:template>
</xsl:stylesheet>
