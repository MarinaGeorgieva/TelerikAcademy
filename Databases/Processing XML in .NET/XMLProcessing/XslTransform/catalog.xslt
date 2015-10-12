<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <style>
        table {
          border: 1px solid black;
          border-collapse: collapse;
          text-align: center;
        }

        th, td {
          border: 1px solid black;
          padding: 5px;
        }
      </style>

      <body>
        <table>
          <tr bgcolor="#EEEEEE">
            <th>Name</th>
            <th>Artist</th>
            <th>Year</th>
            <th>Producer</th>
            <th>Price</th>
            <th>Songs</th>
          </tr>
          <xsl:for-each select="catalog/album">
            <tr>
              <td>
                <strong>
                  <xsl:value-of select="name"/>
                </strong>
              </td>
              <td>
                <xsl:value-of select="artist"/>
              </td>
              <td>
                <xsl:value-of select="year"/>
              </td>
              <td>
                <xsl:value-of select="producer"/>
              </td>
              <td>
                <xsl:value-of select="price"/>$
              </td>
              <td>
                <xsl:for-each select="songs/song">
                  <div>
                    <strong>
                      <xsl:value-of select="title"/>
                    </strong> -
                    <xsl:value-of select="duration"/>
                  </div>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
