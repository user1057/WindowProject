#version 330 core
in vec3 ourColor;
in vec3 aPosVal;
out vec4 FragColor;
void main()
{
   FragColor = vec4(aPosVal,1);
}