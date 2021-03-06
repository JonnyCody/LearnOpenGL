#version 330 core
out vec4 Fragcolor;

uniform vec3 objectColor;
uniform vec3 lightColor;

void main()
{
	Fragcolor = vec4(lightColor * objectColor, 1.0);
}