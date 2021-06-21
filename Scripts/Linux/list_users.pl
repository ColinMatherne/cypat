#!/usr/bin/perl
use strict;

my @a_users;
my @file;

my $filename = '/etc/group';
open (my $fh, '<:encoding(UTF-8)', $filename)
	or die "Could not open file '$filename' $!";

while (my $row = <$fh>)
{
	chomp $row;
	push @file, $row;
}

for (my $i = 0; $i < scalar(@file); $i++)
{
	$file[$i] =~ s/.{3}$//;
	my $temp = substr($file[$i], -2);
	my $j = 0;
	if ($temp == 10)
	{
		$file[$i] =~ s/.{5}$//;
		push @a_users, $file[$i];
	}
}

for (my $i = 0, my $j = 1; $i < scalar(@a_users); $i++, $j++)
{
	print "User #$j: $a_users[$i]\n";
}
