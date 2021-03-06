#!/usr/bin/perl
#																								DOES NOT SUPPORT MORE THAN 30 USERS
#																									  ONLY FOR UBUNTU/DEBIAN
use strict;
# use warnings;					Auto typecast doesn't like this when "if (temp == '10')" to check if a UID is 1000 or over

print "\t\t\tREMEMBER TO RUN AS SUDO\n";

use feature "switch";

# Assign most vars
my @programs;
my $temp;
my @new;
my @file;
my @a_users;

my $filename = '/etc/group';
open(my $fh, '<:encoding(UTF-8)', $filename)
	or die "Could not open file '$filename' $!";

# Make array of all users
while (my $row = <$fh>)
{
	chomp $row;
	push @file, $row;
}

# Find all users with REGEX
for (my $i = 0; $i < scalar(@file); $i++)
{
	$file[$i] =~ s/.{3}$//;
	my $temp = substr($file[$i], -2);
	if ($temp == '10')
	{
		$file[$i] =~ s/.{5}$//;
		push @a_users, $file[$i];
	}
}

# Print all users and have a number with them
for (my $i = 0, my $j = 1; $i < scalar(@a_users); $i++, $j++)
{
	print "User #$j: $a_users[$i] ";
	print "\n";
}

print "Enter the numbers for the admin users: ";
$temp = <STDIN>;
chomp $temp;

my @input = split(' ', $temp);

# Switch for selecting users
for (my $i = 0; $i < scalar(@input); $i++)
{
	given($input[$i])
	{
		when (1) {push @new, $a_users[0];}
		when (2) {push @new, $a_users[1];}
		when (3) {push @new, $a_users[2];}
		when (4) {push @new, $a_users[3];}
		when (5) {push @new, $a_users[4];}
		when (6) {push @new, $a_users[5];}
		when (7) {push @new, $a_users[6];}
		when (8) {push @new, $a_users[7];}
		when (9) {push @new, $a_users[8];}
		when (10) {push @new, $a_users[9];}
		when (11) {push @new, $a_users[10];}
		when (12) {push @new, $a_users[11];}
		when (13) {push @new, $a_users[12];}
		when (14) {push @new, $a_users[13];}
		when (15) {push @new, $a_users[14];}
		when (16) {push @new, $a_users[15];}
		when (17) {push @new, $a_users[16];}
		when (18) {push @new, $a_users[17];}
		when (19) {push @new, $a_users[18];}
		when (20) {push @new, $a_users[19];}
		when (21) {push @new, $a_users[20];}
		when (22) {push @new, $a_users[21];}
		when (23) {push @new, $a_users[22];}
		when (24) {push @new, $a_users[23];}
		when (25) {push @new, $a_users[24];}
		when (26) {push @new, $a_users[25];}
		when (27) {push @new, $a_users[26];}
		when (28) {push @new, $a_users[27];}
		when (29) {push @new, $a_users[28];}
		when (30) {push @new, $a_users[29];}
	}
}

# Make superusers
for (my $i = 0; $i < scalar(@a_users); $i++)
{
	my $found = grep /$a_users[$i]/, @new;
	if ($found)
	{
		system("usermod -aG sudo $a_users[$i]");
		print "$a_users[$i] is now a superuser\n";
	}
	else
	{
		system("deluser $a_users[$i] sudo");
		print "$a_users[$i] removed from sudo group\n";
	}
}


print "Which programs do you want to install [Default: ufw clamtk rkhunter]\n";
print "If unsure just press [ENTER]\n";
$temp = <STDIN>;
chomp $temp;

my @input = split(' ', $temp);
if (scalar(@input) == 0)
{
	push @programs, 'ufw', 'clamtk', 'rkhunter';
} else
{
	push @programs, @input;
}

# Install all programs via 'apt-get'
for (my $i = 0; $i < scalar(@programs); $i++)
{
	system("apt-get install $programs[$i]");
	print "$programs[$i] was installed\n";
}

system("sudo systemctl enable ufw; sudo systemctl start ufw; sudo ufw enable");

print "Remember to update!";
