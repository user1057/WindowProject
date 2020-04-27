#version 330 core

in vec3 ourColor;
in vec2 TexCoord;

out vec4 FragColor;

uniform sampler2D texture1;
uniform sampler2D texture2;

uniform float mixvar;

void main()
{
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord),0.2) * vec4(ourColor, 1.0);
    //exercise 1
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, vec2(-TexCoord.x,TexCoord.y)),mixvar);
}