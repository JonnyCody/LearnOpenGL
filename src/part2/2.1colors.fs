#version 330 core

in vec3 Normal;
in vec3 FragPos;

out vec4 Fragcolor;

uniform vec3 objectColor;
uniform vec3 lightColor;
uniform vec3 lightPos;

void main()
{
	float ambientStrenth = 0.1;
	vec3 ambient = ambientStrenth * lightColor;
	
	vec3 norm = normalize(Normal);
	vec3 lightDir = normalize(lightPos - FragPos);
	float diff = max(dot(norm, lightDir), 0.0);
	vec3 diffuse = diff * lightColor;
	vec3 result = (ambient + diffuse) * objectColor;
	Fragcolor = vec4(result, 1.0);
}